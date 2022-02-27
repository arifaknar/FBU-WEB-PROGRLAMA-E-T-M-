USE master
create database VeriTipleriDB
-- mETÝNSEL Veri Tipleri
char(10) --her zaman belirtilen boyutta bellekte yer kaplar.Mssql in sahip olduðu dil dýþýndaki karakterleri tanýmaz.
nchar(10)--Karakter olarak her dilinin karakterlei girilebilir.Unicode,ASCII destekler.

varchar -- 8000 karakter e kadar veri alýr. 
nvarchar -- 4000 karakter veri alýr.
varchar(Max)-- 2gb veriye kadar saklar.
text,ntext--2 gb a kadar yer saklar. Maaliyetlidir. pek tercih edilmez

-- Binary Veri Tipleri(a=0X43 GÝBÝ)
varBinary(50) -- girilen karakter kadar yer açar.

select convert(Varbinary(Max),'A'); --BÝR KARAKTERÝN BÝNARY KARÞILIÐI

--sAYISAL vERÝ tÝPLERÝ
bit --0,1 alýr

int --
bigint --
smallint--
tinyint --0-255 arasý veri alýr.
decimal(18,2)- max 18byte alan kaplar.
numeric(18,2)- 
float--
real--
money--
smallmoney--

--Tarih veri tipleri
date-- yalnýzca tarih yýl-ay-gün
datetime-- tarih ve zaman
smalldatetime-- yukarýdakilere göre daha az yer kaplar.
datetime2-- Bankacýlýk iþlemlerinde kullanýlýr. milisaniyenin 7 basamak altýna inebiliyor.
datetimeoffset-- karþýlaþtýrmalý tarih. araþtýr!!!!.
time--sadece saat ve dakikayý tutar.

xml-- veritabanýný xml olarak paylaþmak istediðimizde.
uniqueidentifier-- eþssiz sayý üretir.

variant-araþtýr
geografy-araþtýr
timestamp-
