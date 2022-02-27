--Sql Tablodan Veri Seçme
select * from Filmler
select * from Kategoriler
--Sql Güncelleme 
UPDATE Filmler
SET KategoriId =2,Ad='Harry Potter'
WHERE Filmler.Id=14;
--Sql Ekleme
insert into Filmler(Ad) values('Cennetin Krallýðý');

delete from Kategoriler where Id=3