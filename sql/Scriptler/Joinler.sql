--JO�N ************
/*
- b�R VEYA B�RDEN TABLOYU B�RB�R� �LE ili�kilendirmemizi sa�layan ve bire bir ili�kili verileri birle�tirmek i�in getiren sql keyword�.
Left Join:On keyword�n�n solundaki olan tabloyu referans al�r ve sol tabloyu getirir.
Right Join:On keyword�n�n sa��ndaki olan tabloyu referans al�r ve sa� tabloyu getirir.
Full Join: B�t�n tablolar� getirir.
Cross Join: Matris yap�l�d�r.Deparforme olarak bilinir. Ama kullan�ld���� yerler vard�r.
self join: Where ile joinlenen tiplerdir. Sadece inner ile olur.
- 
*/
use Northwind
select * from PersonelDetay pd
select * from Cinsiyet cns
select * from MedeniDurum md
select * from Din d

------------------- INNER JOIN ----------------------------

select pd.Ad , ISNULL(pd.Numara,0) as Numara , cns.CinsiyetAdi from PersonelDetay pd
INNER JOIN Cinsiyet cns
ON pd.CinsiyetId = cns.CinsiyetID

select pd.ID , md.MedeniDurum from PersonelDetay pd
INNER JOIN MedeniDurum md
ON pd.MedeniId = md.MedeniDurumID

--ka� evli ka� bekar
select md.MedeniDurum , count(*) medeni_hal_toplam from PersonelDetay pd
INNER JOIN MedeniDurum md
ON pd.MedeniId = md.MedeniDurumID
group by md.MedeniDurum

--hangi dinden ka� ki�i
select d.Din , count(*) from PersonelDetay pd 
INNER JOIN Din d ON pd.DinId = d.DinID
where d.DinID !=5
group by d.Din
having COUNT(*)>1
order by 2


select pd.Ad,md.MedeniDurum, cs.CinsiyetAdi,d.Din from PersonelDetay pd
inner join MedeniDurum md
on md.MedeniDurumID=pd.MedeniID
inner join Cinsiyet cs
on cs.CinsiyetID=pd.CinsiyetID
inner join Din d
on d.DinID=pd.DinID




---------------- SELF JOIN (where ile kullan�l�r) ---------------------

select pd.MedeniId , count(*) toplam from PersonelDetay pd, MedeniDurum md
where pd.MedeniId = md.MedeniDurumID
group by pd.MedeniId

----------------	Left JOIN (Soldaki tabloyu fuller) ---------------------

select count(*) from MedeniDurum md
inner join PersonelDetay pd
on pd.MedeniID=md.MedeniDurumID


select pd.Ad,ISNULL(md.MedeniDurum,'Medeni Durum Bilgisi Bo�'),
case when md.MedeniDurum is  NULL
then 'Medeni Durum Bilgisi Bo�'
else Md.MedeniDurum end
from PersonelDetay pd
left join MedeniDurum md
on pd.MedeniID=md.MedeniDurumID

Select pd.Ad,cs.CinsiyetAdi,
ISNULL(cs.CinsiyetAdi,'Cinsiyet Bilgisi Bo�'),
case when cs.CinsiyetAdi is null 
then 'Cinsiyet Bilgisi Bo�'
else cs.CinsiyetAdi end
from PersonelDetay pd
left join Cinsiyet cs
on cs.CinsiyetID=pd.CinsiyetID

----------------	Right JOIN yada right outer join (SA�DAK� tabloyu fuller) ---------------------

select * from Din d
Right join PersonelDetay pd
on pd.DinID=d.DinID



----------------	Cross JOIn ---------------------
select pd.ID,cs.CinsiyetID from PersonelDetay pd 
cross join Cinsiyet cs
where cs.CinsiyetID!=4

select * from(
select pd.ID,cs.CinsiyetID from PersonelDetay pd 
cross join Cinsiyet cs
) xx --(alias)
inner join Din d
on xx.ID=d.DinID
where d.Din<>'Hristiyan'