--TRIGGERS
/*
**** .net ve baþka programlama dili tarafýnda çaðrýlamazlar.
--Triggerlar database de tetikleyici olarak iþlev görür.
--Tetiklemeden kasýt, bir dml (insert,update,delete) gibi bir iþlem gerçekleþtiðinde
(transaction bazlý iþlem iþlem) tetiklenir.
-- Bir iþ yaparlar geriye döndürülen iþlem select olabilir. Fonksiyon matýðýndaki gibi bir geri dönüþ iþlemi deðildir.
-- Parametre almazlar.
--  Sql transaction log oluþturulabilir.
vs gibi loglamalarýný yapabiliriz.böylece tablo bazlý iþlemlerimiz geriye dönük nasýl
-- Bir tabloda ekleme iþlemi olduðunda o tabloya baðlý FK tablosuna gidip bir güncelleme, silme ve ekleme iþlemi yapabiliriz.
-- Database üzerinde ALTER veya DROP gibi süreçlere engeller koyabiliriz.
-- Triggerlar otomatik olarak çalýþýrlar. Dolayýsýyla unutmamalý ve sürekli kontrol edilmeli. Bir tablo üzerinde iþlem 
yapacaksak veya o tablonun baðlý olduðu bir tablo varsa Örneðin;
-- Triggerlar iþlem anýnda, iþlem öncesinde veya sonrasýnda tetiklenebilirler.
-- personel departman gibi... muhakkak baðlý olduðu tabloda da trigger olup olmadýðý kontrol edilmeli.
--	Stored prosedürler den farký paremetre almaz, geriye deðer döndürmez, execute edilmez.
-- Not: Çalýþýlan iþletmenin yazýlým ekibi ile de paylaþabilirsiniz.
-- Not2: Delete trigger da truncate table komutunun çalýþmayacaðý düþünülmemelidir, çalýþýr.

--LÝNKED SERVER ARAÞTIR!!!

--ALL SERVER TRIGGER LAR veri tabaný nesnesidir.
server object>trýggers altýnda bulunurlar.
silmek istediðinde => sað týk > script_server_triggers>drop script

--loglama için sys.dm-exec_query_stats
sys.dm_exec_sql() bakarsýn.!!!
*/
--TRIGGER AKTIF/PASIF YAPMA
ENABLE TRIGGER TRG_TABLO_SILINMEZ3 ON PERSONEL_BORDRO_TBL_YDK3
DISABLE TRIGGER TRG_TABLO_SILINMEZ3 ON PERSONEL_BORDRO_TBL_YDK3
-- YAZIM KURALLARI

--ORNEK 1
USE SP_DB
CREATE TRIGGER TRG_TABLO_SILINMEZ3
ON PERSONEL_BORDRO_TBL_YDK3
FOR DELETE 
AS
BEGIN
	PRINT 'EYYY SQL DEVELOPER, SEN KIMSIN YAA. TABLO SILMEYÝ SENDEN OGRENECEK DEGILIZ'
	ROLLBACK
	RETURN
END

SELECT *  INTO PERSONEL_BORDRO_TBL_YDK3 FROM PERSONEL_BORDRO_TBL
SELECT * FROM PERSONEL_BORDRO_TBL_YDK3
DELETE FROM PERSONEL_BORDRO_TBL_YDK3
DELETE FROM PERSONEL_BORDRO_TBL_YDK3 WHERE ID=3


TRUNCATE TABLE PERSONEL_BORDRO_TBL_YDK


--ORNEK2
CREATE TRIGGER TRG_DATABASE_CREATE
ON ALL SERVER --SUNUCU ÜZERÝNDE OLUÞTURULDU TETÝKLEYÝCÝ
AFTER CREATE_DATABASE
AS
BEGIN
	PRINT 'DATABASE OLUÞTURULDU'
END

CREATE TRIGGER TRG_DATABASE_DROP
ON ALL SERVER --SUNUCU ÜZERÝNDE OLUÞTURULDU TETÝKLEYÝCÝ
AFTER DROP_DATABASE
AS 
BEGIN
	PRINT 'DATABASE DROP EDILDI'
END

CREATE DATABASE TEST_CREATE
DROP DATABASE TEST_CREATE

--ORNEK 3

CREATE TRIGGER TRG_VÝEW_DROP
ON DATABASE
AFTER Drop_View
AS
BEGIN
	PRINT 'VIEW SÝLÝNDÝ ALLAH RAHMET EYLESÝN'
END

DROP VIEW vw_ilkview1

--ORNEK 5

CREATE TRIGGER TRG_NORTHWIND_TBL_CNTRL
ON DATABASE
FOR DROP_TABLE
AS
BEGIN
	PRINT 'SEN KIMSIN KI VERÝTABANINDAN TABLO UCURCAN'
	ROLLBACK
END

DROP TABLE Din

--ORNEK 6

CREATE TABLE DELETE_LOG_TBL(
TARIN DATETIME,
KULLANICI VARCHAR(100)
)

CREATE TRIGGER TRG_TABLO_SIL_LOG
ON PERSONEL_BORDRO_TBL
FOR DELETE
AS
BEGIN
	ROLLBACK -- ÖNCE ROLLBACK DÝKKAT
	PRINT 'EYYY SQL DEVELOPER, SEN KIMSIN YAA. TABLO SILMEYÝ SENDEN OGRENECEK DEGILIZ SENI LOGLUYORUM. '

	BEGIN TRAN
		INSERT INTO DELETE_LOG_TBL
		VALUES (
		GETDATE(), --ANLIK TARIH
		SUSER_NAME() --  ÝÞLEMÝ YAPAN VERÝTABANIN KULLANICISI
		)
	COMMIT TRAN
END

DELETE from PERSONEL_BORDRO_TBL

--ornek 7

CREATE TRIGGER TRG_MIKTAR_CNTRL ON [Order Details]
FOR INSERT
AS
BEGIN
	DECLARE @MIKTAR INT
	DECLARE @URUNID INT
	SELECT @MIKTAR=Quantity,@URUNID=ProductID  FROM inserted
	UPDATE Products SET UnitsInStock=UnitsInStock-@MIKTAR WHERE ProductID=@URUNID
END

SELECT * FROM [Order Details] WHERE OrderID=10248
INSERT INTO [Order Details] VALUES
(10248,3,10,2,1)
SELECT UnitsInStock FROM Products WHERE ProductID=3

--ORNEK 8 HER HANGÝ BÝR ÝÞLEMDE LOG KAYDI YAPMA

CREATE TABLE PROJE_YAZILIM_LOG(
TARIH DATETIME,
KULLANICI VARCHAR(50)
)

CREATE TRIGGER TRG_PROJE_YAZILIM
ON PERSONEL_BORDRO_TBL
FOR INSERT,UPDATE,DELETE
AS
BEGIN
	BEGIN TRAN

		INSERT INTO PROJE_YAZILIM_LOG
		VALUES(GETDATE(),
		SUSER_NAME())
	COMMIT TRAN
END

DISABLE TRIGGER TRG_TABLO_SIL_LOG ON PERSONEL_BORDRO_TBL

INSERT INTO PERSONEL_BORDRO_TBL(ID,MAAS,PRIM,AD,SOYAD)
VALUES(20,9820,2000,'ARÝF','AKNAR')

UPDATE PERSONEL_BORDRO_TBL
SET MAAS=8450 WHERE ID=20

DELETE PERSONEL_BORDRO_TBL WHERE ID=20

--ORNEK 9
/*
NORTHWÝND
--PRODUCT TABLOSUNA ÜRÜN EKLENDÝÐÝNDE OTOMATÝK OLARAK EKLENEN ÜRÜNE SÝPARÝÞ GÝRÝÞÝ YAPILIYOR OLSUN VE ÝLGÝLÝ SÝPARÝÞÝN BE DEFAULT SÝPARÝÞ OLDUÐUNU BÝLEYÝM
-- YANÝ ÞÝRKETÝMÝZE BÝR ÜRÜN GÝRÝÞÝ YAPILMIÞSA BUNUN ÝLK SÝPARÝÞ OLDUÐUNU BÝLEYÝM.
-- SON HALÝNÝ LÝSTELEYELÝM.
-- SÝPARÝS NO,URUN ADI,MIKTAR VE ACIKLAMA ALANI
*/

SELECT * FROM Products

CREATE TRIGGER TRG_ADD_PRODUCT
ON Products
FOR INSERT
AS
BEGIN

	PRINT 'Yeni Ürün Giriþi yapýldý.'
	
END

CREATE TRIGGER TRG_ADD_Products2
ON Products
FOR INSERT
AS
BEGIN
	BEGIN TRAN
	DECLARE @PRODUCT_ID INT;
	SELECT @PRODUCT_ID=ProductID FROM inserted

				INSERT INTO [Order Details] VALUES(10248,@PRODUCT_ID,10,1,1)
				COMMIT TRAN
		
END

SELECT * FROM Products
INSERT INTO Products
VALUES('DENEME',1,1,'10BOXES X 20 BAGS',10,30,0,10,0)




