use AdventureWorks20122

-- TABLE DEÐÝÞKEN OLUÞTURMA -- EVDE CALIÞ BUNU TEKRAR!!

declare @Musterilerimiz TABLE (MusteriId INT,Ad VARCHAR(50),Soyad VARCHAR(25))
INSERT INTO @Musterilerimiz(MusteriId,Ad,Soyad)
SELECT Musteri.CustomerID,FirstName,LastName from Person.Person as Kisi
INNER JOIN Sales.Customer Musteri ON Kisi.BusinessEntityID=Musteri.PersonID;

SELECT MusteriId,Ad,Soyad FROM @Musterilerimiz;

-- TABLE DEÐÝÞKEN OLUÞTURMA

DECLARE @Ogrenci TABLE (OgrenciId INT,AD VARCHAR(50),SOYAD VARCHAR(25))
INSERT INTO @Ogrenci
select p.BusinessEntityID,p.FirstName,p.LastName from Person.Person p

select o.OgrenciId,O.AD,O.SOYAD from @Ogrenci o

--ORNEK 

DECLARE @UserIds TABLE( RowId INT, UserId INT)
DECLARE @TABLE1 TABLE(UserId int, CustomerId INT,CÝTY VARCHAR(100), [State] VARCHAR(100))
INSERT INTO @UserIds
SELECT 1,34
UNION ALL
SELECT 2,24
UNION ALL
SELECT 3,40

DECLARE @Counter INT,@TotalCount INT, @UserId INT
SET @Counter=1
SET @TotalCount=(SELECT COUNT(*) FROM @UserIds)

--ÝSLEM 1

WHILE(@Counter <= @TotalCount)
	BEGIN
		SET @UserId=(SELECT UserId FROM @UserIds WHERE RowId=@Counter)
		print('insert 1')
		INSERT INTO @TABLE1 (UserId,CustomerId,CÝTY,[State])
		VALUES(@UserId,0,
			(SELECT City  FROM Northwind.DBO.Employees where EmployeeID=ceiling(rand()*10)),
			'Florida')
		DECLARE @cityCntrl varchar(20)=(select City from Northwind.dbo.Employees where @UserId=@Counter)
		Print 'Döngü Kontrol'
		DECLARE @Counter2 INT=1;
	
	--ÝSLEM 2
		WHILE((SELECT COUNT(*) FROM @TABLE1)>=@Counter2)
			BEGIN
			PRINT 'kONTROL 1'
			IF((SELECT COUNT(*) FROM @TABLE1 WHERE CÝTY=@cityCntrl)>0)
				BEGIN
					PRINT('BU ÞEHÝR KAYDI VAR')
					SET @Counter=@Counter+1
					SET @Counter2=@Counter2+1
					CONTINUE
				END
			ELSE
				BEGIN 
					SET @Counter=@Counter+1
					SET @Counter2=@Counter2+1
				END
			END
		SET @Counter=@Counter+1
		CONTINUE
	END
SELECT * FROM @TABLE1 















