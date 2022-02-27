



alter table Ogrenciler add constraint CK_Ogrenciler_Point check(Point>=0 and Point<=100)
insert into Ogrenciler(Name,Surname,Point) values('Alex','Cres',9) 

select * from Ogrenciler order by Point asc
/*avg:Sütun ortalama Alma*/
select avg(Point) AS 'Puanların Ortalaması' from Ogrenciler 
/*sum:sütunu toplar.*/
select sum(Point) AS 'Puanların Toplamı' from Ogrenciler
/*count:Kaç adet olduğunu sayar sütunun.*/
select count(Name) AS 'Kişi Sayısı' from Ogrenciler 


select * from Ogrenciler
/*
LİKE:Belirtilen koşula göre içerisinde olanları aramak için kullanılır.
NOT LİKE: Belirtilen koşula göre içerisinde olmayanları arar.
Not: MS Access, yüzde işareti (%) yerine yıldız işareti (*) ve alt çizgi (_) yerine soru işareti (?) kullanır.
*/

-- 'a%' ilk harfi a olan verileri seçer.
SELECT * FROM Ogrenciler WHERE Name LIKE 'a%'

-- '%l' son harfi l olan verileri seçer.
SELECT * FROM Ogrenciler WHERE Name LIKE '%l'

-- '%i%' ile içerisinde i geçen verileri seçer.
SELECT * FROM Ogrenciler WHERE Name LIKE '%i%'

-- '__i%' ile 2 alt çizden sonra gelen i ve sonundaki % işaretinin anlamı 3. karakteri i olan ve devamı olabilen yada olmayan verileri seçer.
SELECT * FROM Ogrenciler WHERE Name LIKE '__i%' 

-- 'e%r' ile ilk harfi e son harfi r olan verileri seçer.
SELECT * FROM Ogrenciler WHERE Name LIKE 'e%r' 

-- '%l' ile sonu l olmayan verileri seçer.
SELECT * FROM Ogrenciler WHERE Name NOT LIKE '%l' 

-- '%[rl]' ile sonu r,l olan verileri seçer.
SELECT * FROM Ogrenciler WHERE Name LIKE '%[rl]'

-- IN ('Emir','Alex') ifadesinde IN ile  name i emir ve alex olan verileri seçer.
SELECT * FROM Ogrenciler WHERE Name IN ('Emir','Alex')

-- NOT IN ('Emir','Alex') ifadesinde IN ile  name i emir ve alex olmayan verileri seçer.
SELECT * FROM Ogrenciler WHERE Name NOT IN ('Emir','Alex')

-- IN (SELECT Point FROM Ogrenciler) ifadesinde IN ile  çoklu arama için parantez içerisinde olan pointleri kullanır ve verileri seçer.
SELECT * FROM Ogrenciler WHERE Point IN (SELECT Point FROM Ogrenciler)

-- BETWEEN 50 AND 100 ifadesinde BETWEEN VE AND ile Pointleri 50-100 arasında olan verileri seçer.
SELECT * FROM Ogrenciler WHERE Point BETWEEN 50 AND 100

-- BETWEEN 50 AND 100 ifadesinde NOT BETWEEN VE AND ile Pointleri 50-100 arasında olmayan verileri seçer.
SELECT * FROM Ogrenciler WHERE Point NOT BETWEEN 50 AND 100

-- BETWEEN 'A' AND 'F'ifadesinde  BETWEEN VE AND ile Nameleri A-E arasında olan verileri seçer.
SELECT * FROM Ogrenciler WHERE Name  BETWEEN 'A' AND 'F' ORDER BY Point ASC



