--Sql Tablodan Veri Se�me
select * from Filmler
select * from Kategoriler
--Sql G�ncelleme 
UPDATE Filmler
SET KategoriId =2,Ad='Harry Potter'
WHERE Filmler.Id=14;
--Sql Ekleme
insert into Filmler(Ad) values('Cennetin Krall���');

delete from Kategoriler where Id=3