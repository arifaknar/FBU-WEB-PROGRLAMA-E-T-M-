select GETDATE() -- O anki saat ve zaman�n uzun halini verir. �rnek ��kt�:2021-11-29 15:36:14.457
SELECT CURRENT_TIMESTAMP

SELECT SYSDATETIME() -- Sistem Saatini  verir.

SELECT SYSDATETIMEOFFSET() -- Sistem saatini ve sistem saat dilimini verir. �rnek: 2021-11-29 15:39:11.2013122 +03:00

SELECT GETUTCDATE() -- Sistem Saatini  verir. DAHA KISA OLARAK SAN�YRN�N ONDALIK KISMINI.

INSERT INTO DateTime_Types(C_DataTime,C_Date,C_DateTime2,C_DateTimeOffset,C_SmallDateTime,C_Time)  values(GETDATE(),GETDATE(),GETDATE(),GETDATE(),GETDATE(),GETDATE())

SELECT * FROM DateTime_Types