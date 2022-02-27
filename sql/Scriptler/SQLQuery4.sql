use Zomato;
TRUNCATE TABLE FaturaTbl

select * from FaturaTbl with(nolock);

create table Urunler(
ID int identity(1,1) primary key,
UrunKodu nvarchar(50) NOT NULL,
UrunAdi nvarchar(50) NOT NULL
);

create table Personel(
ID int identity(1,1) primary key,
PersonelAd nvarchar(50) NOT NULL,
PersonelSoyad nvarchar(50) NOT NULL,
Adres nvarchar(50)
);