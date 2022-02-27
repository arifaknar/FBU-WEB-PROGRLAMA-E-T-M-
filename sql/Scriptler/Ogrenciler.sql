



alter table Ogrenciler add constraint CK_Ogrenciler_Point check(Point>=0 and Point<=100)
insert into Ogrenciler(Name,Surname,Point) values('Alex','Cres',9) 

select * from Ogrenciler order by Point asc
/*avg:S�tun ortalama Alma*/
select avg(Point) AS 'Puanlar�n Ortalamas�' from Ogrenciler 
/*sum:s�tunu toplar.*/
select sum(Point) AS 'Puanlar�n Toplam�' from Ogrenciler
/*count:Ka� adet oldu�unu sayar s�tunun.*/
select count(Name) AS 'Ki�i Say�s�' from Ogrenciler 


select * from Ogrenciler
/*
L�KE:Belirtilen ko�ula g�re i�erisinde olanlar� aramak i�in kullan�l�r.
NOT L�KE: Belirtilen ko�ula g�re i�erisinde olmayanlar� arar.
Not: MS Access, y�zde i�areti (%) yerine y�ld�z i�areti (*) ve alt �izgi (_) yerine soru i�areti (?) kullan�r.
*/

-- 'a%' ilk harfi a olan verileri se�er.
SELECT * FROM Ogrenciler WHERE Name LIKE 'a%'

-- '%l' son harfi l olan verileri se�er.
SELECT * FROM Ogrenciler WHERE Name LIKE '%l'

-- '%i%' ile i�erisinde i ge�en verileri se�er.
SELECT * FROM Ogrenciler WHERE Name LIKE '%i%'

-- '__i%' ile 2 alt �izden sonra gelen i ve sonundaki % i�aretinin anlam� 3. karakteri i olan ve devam� olabilen yada olmayan verileri se�er.
SELECT * FROM Ogrenciler WHERE Name LIKE '__i%' 

-- 'e%r' ile ilk harfi e son harfi r olan verileri se�er.
SELECT * FROM Ogrenciler WHERE Name LIKE 'e%r' 

-- '%l' ile sonu l olmayan verileri se�er.
SELECT * FROM Ogrenciler WHERE Name NOT LIKE '%l' 

-- '%[rl]' ile sonu r,l olan verileri se�er.
SELECT * FROM Ogrenciler WHERE Name LIKE '%[rl]'

-- IN ('Emir','Alex') ifadesinde IN ile  name i emir ve alex olan verileri se�er.
SELECT * FROM Ogrenciler WHERE Name IN ('Emir','Alex')

-- NOT IN ('Emir','Alex') ifadesinde IN ile  name i emir ve alex olmayan verileri se�er.
SELECT * FROM Ogrenciler WHERE Name NOT IN ('Emir','Alex')

-- IN (SELECT Point FROM Ogrenciler) ifadesinde IN ile  �oklu arama i�in parantez i�erisinde olan pointleri kullan�r ve verileri se�er.
SELECT * FROM Ogrenciler WHERE Point IN (SELECT Point FROM Ogrenciler)

-- BETWEEN 50 AND 100 ifadesinde BETWEEN VE AND ile Pointleri 50-100 aras�nda olan verileri se�er.
SELECT * FROM Ogrenciler WHERE Point BETWEEN 50 AND 100

-- BETWEEN 50 AND 100 ifadesinde NOT BETWEEN VE AND ile Pointleri 50-100 aras�nda olmayan verileri se�er.
SELECT * FROM Ogrenciler WHERE Point NOT BETWEEN 50 AND 100

-- BETWEEN 'A' AND 'F'ifadesinde  BETWEEN VE AND ile Nameleri A-E aras�nda olan verileri se�er.
SELECT * FROM Ogrenciler WHERE Name  BETWEEN 'A' AND 'F' ORDER BY Point ASC



