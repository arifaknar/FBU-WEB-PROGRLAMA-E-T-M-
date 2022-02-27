USE master
create database VeriTipleriDB
-- mET�NSEL Veri Tipleri
char(10) --her zaman belirtilen boyutta bellekte yer kaplar.Mssql in sahip oldu�u dil d���ndaki karakterleri tan�maz.
nchar(10)--Karakter olarak her dilinin karakterlei girilebilir.Unicode,ASCII destekler.

varchar -- 8000 karakter e kadar veri al�r. 
nvarchar -- 4000 karakter veri al�r.
varchar(Max)-- 2gb veriye kadar saklar.
text,ntext--2 gb a kadar yer saklar. Maaliyetlidir. pek tercih edilmez

-- Binary Veri Tipleri(a=0X43 G�B�)
varBinary(50) -- girilen karakter kadar yer a�ar.

select convert(Varbinary(Max),'A'); --B�R KARAKTER�N B�NARY KAR�ILI�I

--sAYISAL vER� t�PLER�
bit --0,1 al�r

int --
bigint --
smallint--
tinyint --0-255 aras� veri al�r.
decimal(18,2)- max 18byte alan kaplar.
numeric(18,2)- 
float--
real--
money--
smallmoney--

--Tarih veri tipleri
date-- yaln�zca tarih y�l-ay-g�n
datetime-- tarih ve zaman
smalldatetime-- yukar�dakilere g�re daha az yer kaplar.
datetime2-- Bankac�l�k i�lemlerinde kullan�l�r. milisaniyenin 7 basamak alt�na inebiliyor.
datetimeoffset-- kar��la�t�rmal� tarih. ara�t�r!!!!.
time--sadece saat ve dakikay� tutar.

xml-- veritaban�n� xml olarak payla�mak istedi�imizde.
uniqueidentifier-- e�ssiz say� �retir.

variant-ara�t�r
geografy-ara�t�r
timestamp-
