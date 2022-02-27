--1 sql pageing ÝÞLEMÝ

SELECT ProductID,ProductName FROM Products ORDER BY ProductID
OFFSET 0 ROWS FETCH NEXT 5 ROWS ONLY


--HIZALNDIRILMIÞ SQL

/*
--SELECT KULLANIMI

SELECT ÝÇÝN ASLA * KULLANMA
ALIAS KULLAN

*/
/*
TOP KULLANIMI

ALIÞKANLIK EDÝN SORGULARDA. NUMUNE DATA GÖRMEK ÝÇÝN KULLAN. VERÝ HACMÝ BÜYÜK OLAN TABLOLARDA KULLAN. OFFSET DE KULLANABÝLÝRSÝN. */


/*

--WHERE
PARAMETRE GÖNDERÝRKEN UNIQ ALAN SORGULAMAN GEREKEBÝLÝR. KULLAN.
*/
/*
"IS NULL","<>","!=","!>","!<","NOT","NOT EXISTS","NOT IN","NOT LIKE" VE "LIKE '500'" => NONSECÝBIL(SARGABLE)(NON INDEX OLARAK DA GEÇEBÝLÝR.)

*YUKARIDAKÝ OPERATÖRLER ASLA INDEX LERÝ SANA KULLANDIRMAZ !!
* BUNUN YERÝNE INDEX ÝLE JOIN ATARSAN DAHA HIZLI VERÝLER GELÝR. ÝÞLEM HIZLI YAPILIR.
*/

/*

DISTINCT
/*
*ÇOKLAMAYI ENGELLEMEK ÝÇÝN KULLANILIR. VERÝ ÇOKLAMASINI ENGELLEMEK ÝÇÝN  NORMALÝZASYONU ÝYÝ BÝLMELÝSÝN.
* SIKINTILIDIR. SUNUCUYU SIKINTIYA SOKAR. MAALÝYETLÝDÝR.
*/



/*
ORDER BY 

*MALÝYETLÝDÝR.
*YERINE PARTION YAZABÝLÝRSÝN.

*/


/*

GROUP BY

* dýstýnct den farký aggreate functýonlarda vardýr.

*/

/*

GEÇÝCÝ TABLOLAR(SP)

Stored prosedure lerde kullanman tavsiye edilir.

*/




/*

UNIAN ALL KULLANIMI

**büyük veriilerde performan sorunu yaratýr.

*/


/*

JOIN KULLANIMI

Joýn attýðýn tablolarda index atýp sorgunun ne kadar süre de geldiðinde dikkat eetmen gerekir.

*/

/*
EXISTS KULLANIMI

Ýndeksleri siler. disable eder.
Büyük datalarda in yerine exists kullan.
*/



/*

SUBQUERY YERÝNE JOIN KULLANIMI

Münkün olduðunca subquery yerine join kullan.

Subqery den kaçamadýðýn zamanlarda ....
*/

/*

HAVING KULLANIMI
 maliyetlidir. Sorun ve yavaþlama varsa havinglere dikkat et.
*/

/*

NCHAR KULLANIMI

kullanmaktan kaçýn.

*/

/*

WITH(NOLOCK) KULLANIMI



*/




/*

SET NOCOUNT ON TRY CATCH => araþtýr google da

Transaction ýnýn iþlemini toplam count üzerinde sorgulama direk iþlemi yap demek için kullanýlýrç

*/

/*

TRAY CATCH

HATALARDAN KAÇINMA ÝÇÝN KULLANILIR.
ÝÞÝ KOLAYLAÞTIRIR.

*/

/*

TRANSACTION DAN KAÇINMA

YOÐUN SQL LERDE BELLÝ BÝR DATA ÜZERÝNDE ÝÞLEM YAP SONRA HEPSÝE UYGULA.

*/

/*

CURSOR

YAVAÞLATIR.

*/

/*

EXECUTE SP_EXECUTESQL N'SELECT * FROM PRODUCTS'

*/



*/

--DÜNYANIN EN ÖNEMLÝ OPTÝMÝZE SQL SUNUCUSU EXECUTABLE önemli !!!!!!!!!!!!!!

EXECUTE SP_EXECUTESQL N'SELECT * FROM PRODUCTS'

--sp_executesql ile sorgu hýzlandýrma -- birden fazla cashleme yapmaz ayný sorgu için.

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

SELECT usecounts [Kullaným Adeti],sql Sorgu From sys.syscacheobjects

--2- ram temizlemek için

DBCC FREEPROCCACHE
DBCC DROPCLEANBUFFERS

--3- ÝSTATÝSTÝKLER - BÝLGÝSAYARIN ÝLGÝYÝ ÝÞLEME AYIRDIÐI ZAMAN VE BELLEÐÝ BELÝRTÝR.

SET STATISTICS IO ON
SET STATISTICS TIME ON
SELECT * FROM Products

--4- EXECUTION PLAN 
--ctrl+l