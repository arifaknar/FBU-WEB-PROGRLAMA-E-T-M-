use Northwind

--�ehirlere g�re m��rei say�lar� azalan
select c.City,COUNT(*) toplam_musteri from Customers c
group by c.City 
order by toplam_musteri desc 

select e.TitleOfCourtesy,COUNT(*)  from Employees e
group by e.TitleOfCourtesy order by 2 --

 -- group by yaparken tekrar etmeyen veriler select edilmez. �rnk.  Kategori bazl� stok ortalamalar�.
select p.CategoryID,avg(p.UnitsInStock) ortalama_stok_miktari 
from Products p
group by p.CategoryID
order by 1

--ORDERS Group By Examples

--
select ord.CustomerID,sum(ord.Freight) zarar from Orders ord
group by ord.CustomerID
order by 2 desc

SELECT ProductID, SUM(Quantity) AS Total_Quantity  FROM [Order Details]  GROUP BY ProductID  ORDER BY Total_Quantity DESC

-- Distinct-- Tekrarlayan datalar� gizler. Group by dan fark� ayn� olanlar� birle�tirir.Group by select k�sm�nda zorurluluk k�lar. Maaliyetlidir. Distinct B�y�k veri yap�lar�nda sistemi Yava�lat�r.

select distinct e.TitleOfCourtesy,e.BirthDate from Employees e

select distinct e.Title+' '+e.TitleOfCourtesy from Employees e --2 li distinct leme.

--Having M�lakatlarda mutlaka ��kar. Where gibi �al���r. Ama where den farkl�d�r. Her zaman bir gruplama al�r.aggreate fonksiyona ko�ul atama

select * from Employees e

select * from Products p


select p.CategoryID,AVG(p.UnitsInStock) Stok_ort from Products p
group by p.CategoryID
having AVG(p.UnitsInStock)>27
order by 2 desc

 

select r.RegionDescription,COUNT(*) from Region r
group by r.RegionDescription
having COUNT(*)>1;

SELECT ProductID, SUM(Quantity) AS Total_Quantity  FROM [Order Details] where OrderID>10000  GROUP BY ProductID  
having sum(Quantity)>1300 

select year(OrderDate) as SiparisTarihi,ord.CustomerID,count(ord.OrderID) as Siparis_Toplami  from Orders ord
group by year(OrderDate),ord.CustomerID
order by ord.CustomerID 

--Except iki tablo aras�nda ili�ki kurar. Birinci tabloda olan ikinci tabloda olmayan kay�t� listeler.

select ProductID from Products
except
select CategoryID from Categories

select city from Employees
except
select City from Customers

--intersect -- iki tablonun ortak elemanlar�n� verir.
select city from Employees
intersect
select City from Customers

--product tablosu i�inde kategoryid si �oklayan ve product �r�nlerimin i�indeki kategoriid si kesi�en tablolar�m�n unitstok miktar� 200 den yada 100 den b�y�k olan

-- m��teriler i�inden personellerimin �ehir bilgileri ayn� olan lar�n bu �ehirlere ait sipari�lerin neler oldu�u ve price>100

-- M�lakatlarda kesin ��kar. 30 sargu �dev 10 tane case 5 intersect 5 except having 10 group by 10 di�er sorgulardan 30
select e.TitleOfCourtesy,
case 
when e.TitleOfCourtesy='Ms.' then 'Bayan'
when e.TitleOfCourtesy='Mrs.' then 'Evli Bayan'
when e.TitleOfCourtesy='Ms.' then 'Bekar Bayan'
when e.TitleOfCourtesy='Mr.' then 'Erkek'
else
'Di�er'
end
from Employees e
