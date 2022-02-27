--TRIGGERS
/*
**** .net ve ba�ka programlama dili taraf�nda �a�r�lamazlar.
--Triggerlar database de tetikleyici olarak i�lev g�r�r.
--Tetiklemeden kas�t, bir dml (insert,update,delete) gibi bir i�lem ger�ekle�ti�inde
(transaction bazl� i�lem i�lem) tetiklenir.
-- Bir i� yaparlar geriye d�nd�r�len i�lem select olabilir. Fonksiyon mat���ndaki gibi bir geri d�n�� i�lemi de�ildir.
-- Parametre almazlar.
--  Sql transaction log olu�turulabilir.
vs gibi loglamalar�n� yapabiliriz.b�ylece tablo bazl� i�lemlerimiz geriye d�n�k nas�l
-- Bir tabloda ekleme i�lemi oldu�unda o tabloya ba�l� FK tablosuna gidip bir g�ncelleme, silme ve ekleme i�lemi yapabiliriz.
-- Database �zerinde ALTER veya DROP gibi s�re�lere engeller koyabiliriz.
-- Triggerlar otomatik olarak �al���rlar. Dolay�s�yla unutmamal� ve s�rekli kontrol edilmeli. Bir tablo �zerinde i�lem 
yapacaksak veya o tablonun ba�l� oldu�u bir tablo varsa �rne�in;
-- Triggerlar i�lem an�nda, i�lem �ncesinde veya sonras�nda tetiklenebilirler.
-- personel departman gibi... muhakkak ba�l� oldu�u tabloda da trigger olup olmad��� kontrol edilmeli.
--	Stored prosed�rler den fark� paremetre almaz, geriye de�er d�nd�rmez, execute edilmez.
-- Not: �al���lan i�letmenin yaz�l�m ekibi ile de payla�abilirsiniz.
-- Not2: Delete trigger da truncate table komutunun �al��mayaca�� d���n�lmemelidir, �al���r.

--L�NKED SERVER ARA�TIR!!!

--ALL SERVER TRIGGER LAR veri taban� nesnesidir.
server object>tr�ggers alt�nda bulunurlar.
silmek istedi�inde => sa� t�k > script_server_triggers>drop script

--loglama i�in sys.dm-exec_query_stats
sys.dm_exec_sql() bakars�n.!!!
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
	PRINT 'EYYY SQL DEVELOPER, SEN KIMSIN YAA. TABLO SILMEY� SENDEN OGRENECEK DEGILIZ'
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
ON ALL SERVER --SUNUCU �ZER�NDE OLU�TURULDU TET�KLEY�C�
AFTER CREATE_DATABASE
AS
BEGIN
	PRINT 'DATABASE OLU�TURULDU'
END

CREATE TRIGGER TRG_DATABASE_DROP
ON ALL SERVER --SUNUCU �ZER�NDE OLU�TURULDU TET�KLEY�C�
AFTER DROP_DATABASE
AS 
BEGIN
	PRINT 'DATABASE DROP EDILDI'
END

CREATE DATABASE TEST_CREATE
DROP DATABASE TEST_CREATE

--ORNEK 3

CREATE TRIGGER TRG_V�EW_DROP
ON DATABASE
AFTER Drop_View
AS
BEGIN
	PRINT 'VIEW S�L�ND� ALLAH RAHMET EYLES�N'
END

DROP VIEW vw_ilkview1

--ORNEK 5

CREATE TRIGGER TRG_NORTHWIND_TBL_CNTRL
ON DATABASE
FOR DROP_TABLE
AS
BEGIN
	PRINT 'SEN KIMSIN KI VER�TABANINDAN TABLO UCURCAN'
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
	ROLLBACK -- �NCE ROLLBACK D�KKAT
	PRINT 'EYYY SQL DEVELOPER, SEN KIMSIN YAA. TABLO SILMEY� SENDEN OGRENECEK DEGILIZ SENI LOGLUYORUM. '

	BEGIN TRAN
		INSERT INTO DELETE_LOG_TBL
		VALUES (
		GETDATE(), --ANLIK TARIH
		SUSER_NAME() --  ��LEM� YAPAN VER�TABANIN KULLANICISI
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

--ORNEK 8 HER HANG� B�R ��LEMDE LOG KAYDI YAPMA

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
VALUES(20,9820,2000,'AR�F','AKNAR')

UPDATE PERSONEL_BORDRO_TBL
SET MAAS=8450 WHERE ID=20

DELETE PERSONEL_BORDRO_TBL WHERE ID=20

--ORNEK 9
/*
NORTHW�ND
--PRODUCT TABLOSUNA �R�N EKLEND���NDE OTOMAT�K OLARAK EKLENEN �R�NE S�PAR�� G�R��� YAPILIYOR OLSUN VE �LG�L� S�PAR���N BE DEFAULT S�PAR�� OLDU�UNU B�LEY�M
-- YAN� ��RKET�M�ZE B�R �R�N G�R��� YAPILMI�SA BUNUN �LK S�PAR�� OLDU�UNU B�LEY�M.
-- SON HAL�N� L�STELEYEL�M.
-- S�PAR�S NO,URUN ADI,MIKTAR VE ACIKLAMA ALANI
*/

SELECT * FROM Products

CREATE TRIGGER TRG_ADD_PRODUCT
ON Products
FOR INSERT
AS
BEGIN

	PRINT 'Yeni �r�n Giri�i yap�ld�.'
	
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




