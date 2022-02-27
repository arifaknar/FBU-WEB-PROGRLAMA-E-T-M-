USE Northwind

--uNÝON AND UNÝON ALL 
--=>Birdenfazla tabloyu tek tablo gibi gösterir. join olmadan birleþtirir ve uniq hale getirir tabloyu.
/*
-Select kolon sayýlarý ayný olmalýdýr.
-Kolon veri tipleri ayný olmalýdýr.
-Ýkisi arasýndaki fark union veriyi çoklamaz. Union all veriyi çoklar.Yani Ortak veri varsa tekler , diðeri ortak olan veriyi iki defa yazar.
-Ýlk select kolonu as olmazsa hata verir.Fiziksel deðilse.
*/

select COUNT(*) FROM Customers c --91 satýr

select COUNT(*) FROM Employees e --10 satýr

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
select FirstName+' '+LastName,'Dýþ Kaynak' ad,'' as Region from Employees
) musteriler
where Region is not null and Len(Region)>0--len uzunluðu alýr sütunun
group by ad,Region

--Soru:Müþterilerin bölgesi region ise dahil etmesin
select * FROM Customers c where c.Region!=''
select * FROM Customers c where c.Region is NOT NULL


