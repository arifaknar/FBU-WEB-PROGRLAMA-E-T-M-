select * from Personeller	

SELECT Ad,Soyad,Sehir FROM Personeller WHERE Sehir!='Antalya'
SELECT Ad,Soyad,Sehir FROM Personeller WHERE Sehir<>'Antalya' -- !,<> e�it olmayanlar� getirir.

SELECT Ad,Soyad,Sehir FROM Personeller WHERE Yas>25

--Inner jO�N �LE  null de�erler varsa onlar�da almaz.
SELECT Personeller.Id,Personeller.Ad,Personeller.Soyad,Personeller.Yas,Personeller.Sehir,Personeller.Maas,PersonelPrim.Prim FROM Personeller INNER JOIN PersonelPrim ON Personeller.Id=PersonelPrim.PersonelId 
--lEFT jO�N �LE SOL tarafta yazd���m�z i�inde kar�l�k gelen null de�erler varsa onlar�da al�r.Right join i�in tam tersi ge�erli.
SELECT * FROM Personeller LEFT JOIN PersonelPrim ON Personeller.Id=PersonelPrim.PersonelId 

SELECT * FROM Personeller RIGHT JOIN PersonelPrim ON Personeller.Id=PersonelPrim.PersonelId 

-- Group By �ehirlere g�re maa� toplamlar�
SELECT Sehir, SUM(Maas) AS Maas FROM Personeller GROUP BY Sehir