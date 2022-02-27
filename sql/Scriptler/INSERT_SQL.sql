CREATE DATABASE TestDB
use TestDB

/* CONVERT AND CAST*/

SELECT CONVERT(int,'25') --�NTE CONVERT
SELECT CAST('25' AS INT)

SELECT CONVERT(INT,CAST('25' AS INT))

--FATURA TBL

--CREATE

CREATE TABLE FATURA_TBL(
ID int IDENTITY(1,1) PRIMARY KEY,
FATURA_TAR DATE,
MIKTAR int,
BIRIM_FIYAT decimal(18,4),
TUTAR AS (MIKTAR*BIRIM_FIYAT),
KDV_DAHIL_TUTAR AS (MIKTAR*BIRIM_FIYAT)*1.18)

--INSERT

INSERT INTO FATURA_TBL
(FATURA_TAR,MIKTAR,BIRIM_FIYAT)
VALUES(GETDATE(),11,11)


INSERT INTO FATURA_TBL
VALUES(GETDATE(),12,12)

INSERT INTO FATURA_TBL
VALUES
(GETDATE(),13,13),
(GETDATE(),14,14),
(GETDATE(),15,15),
(GETDATE(),16,16)

SELECT * INTO #FATURA_TBL_TEST FROM FATURA_TBL -- GE��C� TABLO #TABLO ADI

create table #fatura_test10(
ID int IDENTITY(1,1) primary key,
FATURA_TAR DATE,
MIKTAR int,
BIRIM_FIYAT decimal(18,4),
TUTAR AS (MIKTAR*BIRIM_FIYAT),
KDV_DAHIL_TUTAR AS (MIKTAR*BIRIM_FIYAT)*1.18
)
INSERT INTO #fatura_test10
VALUES
(GETDATE(),13,13),
(GETDATE(),14,14),
(GETDATE(),15,15),
(GETDATE(),16,16)
CREATE TABLE FATURA_TBL_TEST2
(
ID int IDENTITY(1,1) ,
FATURA_TAR DATE,
MIKTAR int,
BIRIM_FIYAT decimal(18,4),
TUTAR int,
KDV_DAHIL_TUTAR int)


TRUNCATE TABLE  FATURA_TBL_TEST2
SET IDENTITY_INSERT FATURA_TBL_TEST2 Off;
SET IDENTITY_INSERT FATURA_TBL_TEST2 ON;
INSERT INTO FATURA_TBL_TEST2
(ID,FATURA_TAR,MIKTAR,BIRIM_FIYAT,TUTAR,KDV_DAHIL_TUTAR,ROW_NUM)
SELECT 2,FATURA_TAR,MIKTAR,BIRIM_FIYAT,TUTAR,KDV_DAHIL_TUTAR,
ROW_NUMBER() OVER(ORDER BY FATURA_TAR) ROW_NUM 
FROM FATURA_TBL WHERE ID=2

SELECT ROW_NUMBER() OVER (ORDER BY FATURA_TAR) ROW_NUM,FATURA_TAR,MIKTAR,BIRIM_FIYAT,TUTAR,KDV_DAHIL_TUTAR INTO FATURA_TBL
FROM FATURA_TBL_TEST2