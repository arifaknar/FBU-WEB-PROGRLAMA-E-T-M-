select * from Personeller	

SELECT Ad,Soyad,Sehir FROM Personeller WHERE Sehir!='Antalya'
SELECT Ad,Soyad,Sehir FROM Personeller WHERE Sehir<>'Antalya' -- !,<> eþit olmayanlarý getirir.

SELECT Ad,Soyad,Sehir FROM Personeller WHERE Yas>25

--Inner jOÝN ÝLE  null deðerler varsa onlarýda almaz.
SELECT Personeller.Id,Personeller.Ad,Personeller.Soyad,Personeller.Yas,Personeller.Sehir,Personeller.Maas,PersonelPrim.Prim FROM Personeller INNER JOIN PersonelPrim ON Personeller.Id=PersonelPrim.PersonelId 
--lEFT jOÝN ÝLE SOL tarafta yazdýðýmýz içinde karýlýk gelen null deðerler varsa onlarýda alýr.Right join için tam tersi geçerli.
SELECT * FROM Personeller LEFT JOIN PersonelPrim ON Personeller.Id=PersonelPrim.PersonelId 

SELECT * FROM Personeller RIGHT JOIN PersonelPrim ON Personeller.Id=PersonelPrim.PersonelId 

-- Group By Þehirlere göre maaþ toplamlarý
SELECT Sehir, SUM(Maas) AS Maas FROM Personeller GROUP BY Sehir