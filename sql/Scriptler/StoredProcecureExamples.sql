--ORNEK 1
CREATE PROCEDURE SP_PERSONEL_SATILIST(@P_EMPID INT)
AS
BEGIN
	
	SELECT X.FirstName,X.LastName,SUM(X.TOPLAM_SATIS) AS TOPLAM_SATIS
	FROM (SELECT E.FirstName,E.LastName,
	(SELECT COUNT(*) FROM Northwind.dbo.[Order Details] ODDTL 
	WHERE OD.OrderID=ODDTL.OrderID) 
	AS TOPLAM_SATIS
	FROM Northwind.dbo.Employees E 
	INNER JOIN Northwind.dbo.Orders OD
	ON E.EmployeeID=OD.EmployeeID
	WHERE E.EmployeeID=@P_EMPID) X
	GROUP BY X.FirstName,X.LastName

END

--Ornek 1 Prosedure kullan�m�
EXEC SP_PERSONEL_SATILIST 1

--ORNEK 2

USE SP_DB
CREATE TABLE PERSONEL_BORDRO_TBL(
ID INT,
AD VARCHAR(50),
SOYAD VARCHAR(50),
MAAS INT,
PRIM INT

)

SELECT * FROM  PERSONEL_BORDRO_TBL

--INSERT PROCEDURE YAZIMI
GO
CREATE PROCEDURE SP_PERSONEL_BORDRO_KAYDET(@P_ID INT,@P_AD VARCHAR(50),@P_SOYAD VARCHAR(50),@P_MAAS INT,@P_PRIM INT)
AS
BEGIN

INSERT INTO PERSONEL_BORDRO_TBL
 VALUES(@P_ID,@P_AD,@P_SOYAD,@P_MAAS,@P_PRIM)
END

--INSERT PROCEDURE KULLANIMI
EXEC SP_PERSONEL_BORDRO_KAYDET 1,'AR�F','AKNAR',7000,1000

--UPDATE PROCEDURE YAZIMI
GO
CREATE PROCEDURE SP_PERSONEL_BORDRO_GUNCELLE(@P_ID INT,@P_AD VARCHAR(50),@P_SOYAD VARCHAR(50),@P_MAAS INT,@P_PRIM INT)
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			UPDATE PERSONEL_BORDRO_TBL 
			SET AD=@P_AD,
			SOYAD=@P_SOYAD,
			MAAS=@P_MAAS,
			PRIM=@P_PRIM
			WHERE ID=@P_ID
		COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
		PRINT 'hATA: '+ERROR_MESSAGE();
	END CATCH
END

--UPDATE PROCEDURE KULLANIMI

EXEC SP_PERSONEL_BORDRO_GUNCELLE 1,'AR�F','AKNAR',7500,1500

SELECT * FROM  PERSONEL_BORDRO_TBL

--DELETE PROCEDURE
--PROC PROSEDURE �N D��ER YAZIMI

CREATE PROC SP_PERSONEL_BORDRO_SIL(@PERSONEL_ID INT, @P_DURUM VARCHAR(50) OUTPUT)
AS
BEGIN
	BEGIN TRY
		DELETE FROM PERSONEL_BORDRO_TBL WHERE ID=@PERSONEL_ID
		SET @P_DURUM=CAST(@@ROWCOUNT AS VARCHAR(50))+ 'ADET KAYIT S�L�ND�.'
 
	END TRY
	BEGIN CATCH
		SET @P_DURUM='B�R HATA OLU�TU.'+ERROR_MESSAGE();
	END CATCH

	SELECT @P_DURUM;
END

--DELETE PROCEDURE KULLANIMI

EXEC SP_PERSONEL_BORDRO_SIL 1,''

SELECT * FROM  PERSONEL_BORDRO_TBL

--SORU : STOK MIKTARI 50 DEN KUCUK 10 DAN FAZLA OLAN VE KATEGOR� C HARF� �LE BA�LAYAN �R�NLER� L�STES�N� OLU�TURAN PROSEDURE
--URUN MIKTARI DE���T�R�LEB�L�R
--KATEGOR�LER �STEN�LD��� KADAR DE���T�R�LEB�L�R.
USE Northwind
GO
ALTER PROC SP_STOK_LISTELE(@P_UNIT_START INT,@P_UNIT_END INT,@P_CATEGORY_NAME_START VARCHAR(50))
AS
BEGIN
	

	SELECT P.ProductName,P.UnitsInStock,C.CategoryName FROM Products P
	INNER JOIN Categories C
	ON C.CategoryID=P.CategoryID
	WHERE UnitsInStock>@P_UNIT_START AND UnitsInStock<@P_UNIT_END AND C.CategoryName LIKE (@P_CATEGORY_NAME_START+'%')

END

EXEC SP_STOK_LISTELE 10,40,'C'

--ORNEK PROCEDURE DEVAM

USE SP_DB

CREATE PROC SP_PERSONEL_BORDRO_TBL_INS(@P_ID INT,@P_AD VARCHAR(50),@P_SOYAD VARCHAR(50),@P_MAAS INT,@P_PRIM INT,@P_ISLEM VARCHAR(50),@P_DURUM VARCHAR(50) OUTPUT
)
AS
BEGIN
	BEGIN TRY
		IF(@P_ISLEM='SELECT')
			BEGIN
				SELECT * FROM PERSONEL_BORDRO_TBL WHERE ID=@P_ID;
				SET @P_DURUM='SELECT SORGUSU �ALI�TI'+CAST(@@ROWCOUNT AS VARCHAR(50));
			END
		ELSE IF(@P_ISLEM='UPDATE')
			BEGIN
				UPDATE PERSONEL_BORDRO_TBL 
				SET 
				ID=@P_ID,
				AD=@P_AD,
				SOYAD=@P_SOYAD,
				MAAS=@P_MAAS,
				PRIM=@P_PRIM
				WHERE ID=@P_ID
				SET @P_DURUM='UPDATE SORGUSU �ALI�TI'+CAST(@@ROWCOUNT AS VARCHAR(50));
			END
		ELSE IF(@P_ISLEM='INSERT')
			BEGIN
				INSERT INTO PERSONEL_BORDRO_TBL 
				VALUES(@P_ID,@P_AD,@P_SOYAD,@P_MAAS,@P_PRIM)
				SET @P_DURUM='INSERT SORGUSU �ALI�TI'+CAST(@@ROWCOUNT AS VARCHAR(50));
			END
		ELSE IF(@P_ISLEM='DELETE')
			BEGIN
				DELETE PERSONEL_BORDRO_TBL 
				WHERE ID=@P_ID
				SET @P_DURUM='DELETE SORGUSU �ALI�TI'+CAST(@@ROWCOUNT AS VARCHAR(50));
				
			END
	END TRY
	BEGIN CATCH
		SET @P_DURUM='ISLEM GER�EKLE�T�R�LEMED�. HATA SAYISI: '+CONVERT(VARCHAR(50),ERROR_NUMBER())+ 'HATA MESAJI'+ ERROR_MESSAGE();
	END CATCH
	SELECT @P_DURUM;
END

SELECT * FROM PERSONEL_BORDRO_TBL
--PROSEDURE KULLANIMI
EXEC SP_PERSONEL_BORDRO_TBL_INS 2,'EM�R','AKNAR',5000,500,'INSERT',''
EXEC SP_PERSONEL_BORDRO_TBL_INS 2,'EM�R','AKNAR',5000,500,'DELETE',''
EXEC SP_PERSONEL_BORDRO_TBL_INS 1,'AR�F','AKNAR',7000,1500,'UPDATE',''
EXEC SP_PERSONEL_BORDRO_TBL_INS 1,'EM�R','AKNAR',5000,500,'SELECT',''

--ORNEK PROCEDURE

ALTER FUNCTION FN_PERSONEL_DURUM()
RETURNS @PERSONELLER TABLE
(
ID INT,
AD VARCHAR(50),
SOYAD VARCHAR(50),
MAAS INT,
PRIM INT
)
AS
BEGIN
	INSERT INTO @PERSONELLER
	SELECT E.EmployeeID,E.FirstName,E.LastName,
	(
		SELECT COUNT(*) TOPLAM_SATIS FROM Northwind.dbo.[Order Details] ODDTL INNER JOIN Northwind.dbo.Orders OD
		ON OD.OrderID=ODDTL.OrderID
		WHERE OD.EmployeeID=E.EmployeeID
		GROUP BY OD.EmployeeID
	),
	(
		SELECT (COUNT(*)*5) AS PRIM FROM Northwind.dbo.[Order Details] ODDTL INNER JOIN Northwind.dbo.Orders OD
		ON OD.OrderID=ODDTL.OrderID
		WHERE OD.EmployeeID=E.EmployeeID
		GROUP BY OD.EmployeeID
	
	)

	FROM Northwind.dbo.Employees E
	RETURN
END

SELECT * FROM FN_PERSONEL_DURUM()

CREATE PROC SP_PERSONEL_TOPLU_MAAS_HESAPLAMA(@P_CALISILAN_GUN INT,@P_ISLEM_DURUM VARCHAR(100) OUTPUT)
AS
BEGIN
	DECLARE @TOPLAM_PERSONEL INT;
	SET @TOPLAM_PERSONEL=(SELECT COUNT(*) FROM FN_PERSONEL_DURUM())
	DECLARE @SAYAC INT;
	SET @SAYAC=0;
	BEGIN TRY
		BEGIN TRAN
			TRUNCATE TABLE PERSONEL_BORDRO_TBL
			INSERT INTO PERSONEL_BORDRO_TBL(ID,AD,SOYAD,MAAS,PRIM)
			SELECT * FROM FN_PERSONEL_DURUM()
			COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN;
		SET @P_ISLEM_DURUM='ISLEM GER� ALINDI'+ERROR_MESSAGE();
		PRINT 'INSERT HATA: '+@P_ISLEM_DURUM
	END CATCH

	WHILE(@SAYAC<=@TOPLAM_PERSONEL)
		BEGIN
			BEGIN TRY
			--PRIM BASINA SAATL�K UCRETLER
				BEGIN TRY
					DECLARE @MAAS INT=(SELECT (PRIM*MAAS)/@P_CALISILAN_GUN FROM PERSONEL_BORDRO_TBL)
					BEGIN TRAN
						UPDATE PERSONEL_BORDRO_TBL
						SET MAAS=@MAAS
						WHERE ID=@SAYAC
						COMMIT TRAN
				END TRY
				BEGIN CATCH
					ROLLBACK TRAN;
					SET @P_ISLEM_DURUM='ISLEM GER� ALINDI'+ERROR_MESSAGE();
					PRINT 'UPDATE HATA: '+@P_ISLEM_DURUM
				END CATCH
			END TRY
			BEGIN CATCH
					SET @P_ISLEM_DURUM='ISLEM GER� ALINDI'+ERROR_MESSAGE();
					PRINT 'DONGU HATA: '+@P_ISLEM_DURUM
			END CATCH
			SET @SAYAC=@SAYAC+1
			IF(@SAYAC=@TOPLAM_PERSONEL)
			RETURN;
		END
END

--kullan�m�
exec SP_PERSONEL_TOPLU_MAAS_HESAPLAMA 10,''
--EKREM K�SEO�LU VER�TABANI MANTI�I VE SEFER ALGAN HER Y�N�YLE C#