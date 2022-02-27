USE Northwind

--uN�ON AND UN�ON ALL 
--=>Birdenfazla tabloyu tek tablo gibi g�sterir. join olmadan birle�tirir ve uniq hale getirir tabloyu.
/*
-Select kolon say�lar� ayn� olmal�d�r.
-Kolon veri tipleri ayn� olmal�d�r.
-�kisi aras�ndaki fark union veriyi �oklamaz. Union all veriyi �oklar.Yani Ortak veri varsa tekler , di�eri ortak olan veriyi iki defa yazar.
-�lk select kolonu as olmazsa hata verir.Fiziksel de�ilse.
*/

select COUNT(*) FROM Customers c --91 sat�r

select COUNT(*) FROM Employees e --10 sat�r

select c.CompanyName FROM Customers c
union
select e.LastName FROM Employees e

select ad,COUNT(*) from (
select c.CompanyName,'Musteri' ad FROM Customers c
union
select e.LastName ,'Personel' ad FROM Employees e
) musteriler
group by ad

select ad,COUNT(*) toplam_sayi,Region from (
select c.CompanyName,'Musteri' ad,c.Region as Region FROM Customers c
union
select e.LastName ,'Personel' ad,'' as Region FROM Employees e
union all
select FirstName+' '+LastName,'D�� Kaynak' ad,'' as Region from Employees
) musteriler
where Region is not null and Len(Region)>0--len uzunlu�u al�r s�tunun
group by ad,Region

--Soru:M��terilerin b�lgesi region ise dahil etmesin
select * FROM Customers c where c.Region!=''
select * FROM Customers c where c.Region is NOT NULL


