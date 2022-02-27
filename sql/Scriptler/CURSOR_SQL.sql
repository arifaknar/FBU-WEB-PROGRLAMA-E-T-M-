---------CURSOR-----------
/*
--Bir veri grubu �zerinde sat�r sat�r i�lem yapmam�z� sa�layan yap�lard�r. Bir �e�it sql in datatable d�r.(c# konusu)
--En �nemlisi GLOBAL bir yap�d�r ve bir�ok (oracle,mssql) veritaban� taraf�ndan desteklenir.
--Sql programlaman�n olmazsa olmaz�dr.
--�nemli cursor i�in olu�turaca��m de�i�ken ile  CURSOR �n i�erisinde ki tutaca��m kolonlar�n veri tipleri ile ayn� olmal�d�r. 
--D�ng� sonras�nda cursor close edilmeli ve sunucunun raminden disponse edilmelidir. DEALLOCATE aksi halde ciddi anlamda transaction sorunlar�na neden olabilir!!

*/

--ORNEK 1
USE Northwind
DECLARE @EMP_ID INT;
DECLARE CUR_CURSOR CURSOR FOR
SELECT E.EmployeeID FROM Employees E WHERE E.City IN ('Seattle','London');
OPEN CUR_CURSOR;
FETCH NEXT FROM CUR_CURSOR INTO @EMP_ID;
WHILE @@FETCH_STATUS = 0
BEGIN
	SELECT * FROM [Order Details] ODDTL 
	INNER JOIN Orders OD
	ON OD.OrderID=ODDTL.OrderID
	WHERE OD.EmployeeID=@EMP_ID
	FETCH NEXT FROM CUR_CURSOR INTO @EMP_ID
END

CLOSE CUR_CURSOR
DEALLOCATE CUR_CURSOR

--ORNEK 2 CURSOR UPDATE

DECLARE @PRODUCT_ID INT
DECLARE @PRODUCT_NAME VARCHAR(50)
DECLARE CUR_C1 CURSOR FOR
SELECT P.ProductID,'YEN� �R�N' AS URUN_ADI FROM Products P WHERE SupplierID=2
OPEN CUR_C1 -- OPEN ED�LMES� GEREKEN CURSOR KEYWORD � DE��L CURSOR IN KEND�S�
FETCH NEXT FROM CUR_C1 INTO @PRODUCT_ID,@PRODUCT_NAME
WHILE @@FETCH_STATUS=0
BEGIN
	UPDATE Products
	SET ProductName=@PRODUCT_NAME
	WHERE ProductID=@PRODUCT_ID
	FETCH NEXT FROM CUR_C1 INTO @PRODUCT_ID,@PRODUCT_NAME
END
CLOSE CUR_C1
DEALLOCATE CUR_C1

SELECT * FROM Products

--ORNEK 3 CURSOR 

CREATE FUNCTION FN_PERSONEL_ZAM_ORAN_HESAP(@PERSONEL_ID INT)
RETURNS INT
BEGIN
	DECLARE @MAAS INT
	SET @MAAS=(SELECT MAAS FROM PERSONEL_BORDRO_TBL WHERE ID=@PERSONEL_ID)
	IF(@MAAS IS NULL OR @MAAS=0)
		BEGIN
			SET @MAAS=dbo.FN_MAAS_HESAPLA(30,@PERSONEL_ID,10)
		END
		RETURN @MAAS
END


CREATE PROC SP_UNVAN_ZAM_ORANLARI(@DURUM VARCHAR(300) OUTPUT)
AS
BEGIN
	DECLARE @ADI NVARCHAR(50),@SOYADI NVARCHAR(50),@UNVAN NVARCHAR(150),@ID INT
	DECLARE PERSONEL_CURSOR CURSOR FOR
	SELECT E.FirstName,E.LastName,E.Title,E.EmployeeID FROM Employees E
	OPEN PERSONEL_CURSOR
	FETCH NEXT FROM PERSONEL_CURSOR INTO @ADI,@SOYADI,@UNVAN,@ID
	WHILE @@FETCH_STATUS=0
		BEGIN
			PRINT @ADI+' '+@SOYADI+' '+@UNVAN
			IF(@UNVAN='Inside Sales Coordinator')
				BEGIN
					BEGIN TRY
						BEGIN TRAN
							UPDATE PERSONEL_BORDRO_TBL
							SET MAAS=(dbo.FN_PERSONEL_ZAM_ORAN_HESAP(@ID)*1.30)
							WHERE ID=@ID
							
						COMMIT TRAN
					END TRY
					BEGIN CATCH
						ROLLBACK
						PRINT ' ZAM YAP %30 ZAM HATASI'
					END CATCH
				END
			ELSE IF(@UNVAN='Sales Representtative')
				BEGIN
					BEGIN TRY
						BEGIN TRAN
							UPDATE PERSONEL_BORDRO_TBL
							SET MAAS=(dbo.FN_PERSONEL_ZAM_ORAN_HESAP(@ID)*1.10)
							WHERE ID=@ID
							
						COMMIT TRAN
					END TRY
					BEGIN CATCH
						ROLLBACK
						PRINT ' ZAM YAP %10 ZAM HATASI'
					END CATCH
				END

			ELSE
				BEGIN
					BEGIN TRY
						BEGIN TRAN
							UPDATE PERSONEL_BORDRO_TBL
							SET MAAS=(dbo.FN_PERSONEL_ZAM_ORAN_HESAP(@ID)*1.05)
							WHERE ID=@ID
							
						COMMIT TRAN
					END TRY
					BEGIN CATCH
						ROLLBACK
						PRINT ' ZAM YAP %5 ZAM HATASI'
					END CATCH
				END		
			FETCH NEXT FROM PERSONEL_CURSOR INTO @ADI,@SOYADI,@UNVAN,@ID
		END

		SET @DURUM='UNVAN ZAMLARI S�STEM TARAFINDAN GER�EKLE�T�R�LM��T�R'
		CLOSE PERSONEL_CURSOR
		DEALLOCATE PERSONEL_CURSOR
		SELECT @DURUM
END

exec SP_UNVAN_ZAM_ORANLARI ''

SELECT * FROM PERSONEL_BORDRO_TBL

SELECT * FROM Employees WHERE EmployeeID=4

/*
SORU
USE ADVENTURE2012
DEPARTMANID,DEPARTMANNAME,PERSONEID,FIRSTNAME,LASTNAME CURSOR MANTI�INDA �L��K�LEND�R�LECEK
HANG� DEPARTMANLARDA HANG� PERSONELLER �ALI�MAKTADIR
PRIN ED�LMES�
*/

DECLARE @DEPARTMENT_ID INT,@DEPARTMENT_NAME VARCHAR(50),@PERSONEID INT,@FIRSTNAME NVARCHAR(10),@LASTNAME NVARCHAR(20)
DECLARE CU_PERSON_DEPARTMAN CURSOR FOR

SELECT D.DepartmentID,D.Name,P.BusinessEntityID,P.FirstName,P.LastName FROM HumanResources.Employee E INNER JOIN HumanResources.EmployeeDepartmentHistory ED ON E.BusinessEntityID=ED.BusinessEntityID
INNER JOIN HumanResources.Department D ON ED.DepartmentID=D.DepartmentID 
INNER JOIN Person.Person P ON P.BusinessEntityID=E.BusinessEntityID 
ORDER BY D.DepartmentID 

OPEN CU_PERSON_DEPARTMAN
	FETCH NEXT FROM CU_PERSON_DEPARTMAN INTO @DEPARTMENT_ID,@DEPARTMENT_NAME,@PERSONEID,@FIRSTNAME,@LASTNAME
	WHILE @@FETCH_STATUS=0
		BEGIN
			PRINT CAST(@DEPARTMENT_ID AS VARCHAR(10))+' '+CAST(@DEPARTMENT_NAME AS VARCHAR(50))+' '+CAST(@PERSONEID AS VARCHAR(50))+' '+CAST(@FIRSTNAME AS VARCHAR(50))+' '+CAST(@LASTNAME AS VARCHAR(50))	

			FETCH NEXT FROM CU_PERSON_DEPARTMAN INTO @DEPARTMENT_ID,@DEPARTMENT_NAME,@PERSONEID,@FIRSTNAME,@LASTNAME	
		END

		CLOSE CU_PERSON_DEPARTMAN
		DEALLOCATE CU_PERSON_DEPARTMAN


/* BACKUP CURSOR*/

DECLARE @NAME VARCHAR(50)  --DATABASE NAME
DECLARE @PATH VARCHAR(256) -- PATH FOR BACKUP F�LES
DECLARE @FILENAME VARCHAR(256) -- FILENAME FOR BACKUP
DECLARE @FILEDATE VARCHAR(20 ) --USED FOR FILE

SET @PATH='C:\Backup\'

SELECT @FILEDATE=CONVERT(VARCHAR(20),GETDATE(),112)
DECLARE DB_CURSOR CURSOR FOR
	SELECT name FROM master.dbo.sysdatabases
	WHERE name NOT IN ('master','model','msdb','tempdb')
	OPEN DB_CURSOR
	FETCH NEXT FROM DB_CURSOR INTO @NAME
	WHILE @@FETCH_STATUS=0
		BEGIN
			SET @FILENAME=@PATH+@NAME+'_'+@FILEDATE+'.BAK'
			BACKUP DATABASE @NAME TO DISK=@FILENAME
			FETCH NEXT FROM DB_CURSOR INTO @NAME
		END

CLOSE DB_CURSOR
DEALLOCATE DB_CURSOR

