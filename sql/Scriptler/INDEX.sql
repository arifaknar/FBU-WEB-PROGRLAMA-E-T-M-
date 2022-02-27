--1 sql pageing ��LEM�

SELECT ProductID,ProductName FROM Products ORDER BY ProductID
OFFSET 0 ROWS FETCH NEXT 5 ROWS ONLY


--HIZALNDIRILMI� SQL

/*
--SELECT KULLANIMI

SELECT ���N ASLA * KULLANMA
ALIAS KULLAN

*/
/*
TOP KULLANIMI

ALI�KANLIK ED�N SORGULARDA. NUMUNE DATA G�RMEK ���N KULLAN. VER� HACM� B�Y�K OLAN TABLOLARDA KULLAN. OFFSET DE KULLANAB�L�RS�N. */


/*

--WHERE
PARAMETRE G�NDER�RKEN UNIQ ALAN SORGULAMAN GEREKEB�L�R. KULLAN.
*/
/*
"IS NULL","<>","!=","!>","!<","NOT","NOT EXISTS","NOT IN","NOT LIKE" VE "LIKE '500'" => NONSEC�BIL(SARGABLE)(NON INDEX OLARAK DA GE�EB�L�R.)

*YUKARIDAK� OPERAT�RLER ASLA INDEX LER� SANA KULLANDIRMAZ !!
* BUNUN YER�NE INDEX �LE JOIN ATARSAN DAHA HIZLI VER�LER GEL�R. ��LEM HIZLI YAPILIR.
*/

/*

DISTINCT
/*
*�OKLAMAYI ENGELLEMEK ���N KULLANILIR. VER� �OKLAMASINI ENGELLEMEK ���N  NORMAL�ZASYONU �Y� B�LMEL�S�N.
* SIKINTILIDIR. SUNUCUYU SIKINTIYA SOKAR. MAAL�YETL�D�R.
*/



/*
ORDER BY 

*MAL�YETL�D�R.
*YERINE PARTION YAZAB�L�RS�N.

*/


/*

GROUP BY

* d�st�nct den fark� aggreate funct�onlarda vard�r.

*/

/*

GE��C� TABLOLAR(SP)

Stored prosedure lerde kullanman tavsiye edilir.

*/




/*

UNIAN ALL KULLANIMI

**b�y�k veriilerde performan sorunu yarat�r.

*/


/*

JOIN KULLANIMI

Jo�n att���n tablolarda index at�p sorgunun ne kadar s�re de geldi�inde dikkat eetmen gerekir.

*/

/*
EXISTS KULLANIMI

�ndeksleri siler. disable eder.
B�y�k datalarda in yerine exists kullan.
*/



/*

SUBQUERY YER�NE JOIN KULLANIMI

M�nk�n oldu�unca subquery yerine join kullan.

Subqery den ka�amad���n zamanlarda ....
*/

/*

HAVING KULLANIMI
 maliyetlidir. Sorun ve yava�lama varsa havinglere dikkat et.
*/

/*

NCHAR KULLANIMI

kullanmaktan ka��n.

*/

/*

WITH(NOLOCK) KULLANIMI



*/




/*

SET NOCOUNT ON TRY CATCH => ara�t�r google da

Transaction �n�n i�lemini toplam count �zerinde sorgulama direk i�lemi yap demek i�in kullan�l�r�

*/

/*

TRAY CATCH

HATALARDAN KA�INMA ���N KULLANILIR.
��� KOLAYLA�TIRIR.

*/

/*

TRANSACTION DAN KA�INMA

YO�UN SQL LERDE BELL� B�R DATA �ZER�NDE ��LEM YAP SONRA HEPS�E UYGULA.

*/

/*

CURSOR

YAVA�LATIR.

*/

/*

EXECUTE SP_EXECUTESQL N'SELECT * FROM PRODUCTS'

*/



*/

--D�NYANIN EN �NEML� OPT�M�ZE SQL SUNUCUSU EXECUTABLE �nemli !!!!!!!!!!!!!!

EXECUTE SP_EXECUTESQL N'SELECT * FROM PRODUCTS'

--sp_executesql ile sorgu h�zland�rma -- birden fazla cashleme yapmaz ayn� sorgu i�in.

CREATE TABLE MUSTERI (
MUSTERI_ID INT,
AD_SOYAD NVARCHAR(100)
)
GO
INSERT MUSTERI VALUES(1,'M1')
INSERT MUSTERI VALUES(2,'M2')
GO
DBCC FREEPROCCASHE

DECLARE @MUSTERI_ID INT
DECLARE @SORGU NVARCHAR(200)

SET @SORGU='SELECT * FROM MUSTERI WHERE MUSTERI_ID='

SET @MUSTERI_ID=1

EXEC(@SORGU+@MUSTERI_ID)

SET @MUSTERI_ID=2

EXEC(@SORGU+@MUSTERI_ID)

SET @SORGU='SELECT * FROM MUSTERI WHERE MUSTERI_ID=@PrmMusteriID'

SET @MUSTERI_ID=1
EXEC sp_executesql @Sorgu, N'@PrmMusteriID INT',@PrmMusteriID =@MUSTERI_ID

SET @MUSTERI_ID=2

EXEC sp_executesql @Sorgu, N'@PrmMusteriID INT',@PrmMusteriID =@MUSTERI_ID

SELECT usecounts [Kullan�m Adeti],sql Sorgu From sys.syscacheobjects

--2- ram temizlemek i�in

DBCC FREEPROCCACHE
DBCC DROPCLEANBUFFERS

--3- �STAT�ST�KLER - B�LG�SAYARIN �LG�Y� ��LEME AYIRDI�I ZAMAN VE BELLE�� BEL�RT�R.

SET STATISTICS IO ON
SET STATISTICS TIME ON
SELECT * FROM Products

--4- EXECUTION PLAN 
--ctrl+l