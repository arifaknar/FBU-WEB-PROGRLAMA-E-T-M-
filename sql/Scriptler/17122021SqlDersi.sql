use Northwind

--Þehirlere göre müþrei sayýlarý azalan
select c.City,COUNT(*) toplam_musteri from Customers c
group by c.City 
order by toplam_musteri desc 

select e.TitleOfCourtesy,COUNT(*)  from Employees e
group by e.TitleOfCourtesy order by 2 --

 -- group by yaparken tekrar etmeyen veriler select edilmez. Örnk.  Kategori bazlý stok ortalamalarý.
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

-- Distinct-- Tekrarlayan datalarý gizler. Group by dan farký ayný olanlarý birleþtirir.Group by select kýsmýnda zorurluluk kýlar. Maaliyetlidir. Distinct Büyük veri yapýlarýnda sistemi Yavaþlatýr.

select distinct e.TitleOfCourtesy,e.BirthDate from Employees e

select distinct e.Title+' '+e.TitleOfCourtesy from Employees e --2 li distinct leme.

--Having Mülakatlarda mutlaka çýkar. Where gibi çalýþýr. Ama where den farklýdýr. Her zaman bir gruplama alýr.aggreate fonksiyona koþul atama

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

--Except iki tablo arasýnda iliþki kurar. Birinci tabloda olan ikinci tabloda olmayan kayýtý listeler.

select ProductID from Products
except
select CategoryID from Categories

select city from Employees
except
select City from Customers

--intersect -- iki tablonun ortak elemanlarýný verir.
select city from Employees
intersect
select City from Customers

--product tablosu içinde kategoryid si çoklayan ve product ürünlerimin içindeki kategoriid si kesiþen tablolarýmýn unitstok miktarý 200 den yada 100 den büyük olan

-- müþteriler içinden personellerimin þehir bilgileri ayný olan larýn bu þehirlere ait sipariþlerin neler olduðu ve price>100

-- Mülakatlarda kesin çýkar. 30 sargu ödev 10 tane case 5 intersect 5 except having 10 group by 10 diðer sorgulardan 30
select e.TitleOfCourtesy,
case 
when e.TitleOfCourtesy='Ms.' then 'Bayan'
when e.TitleOfCourtesy='Mrs.' then 'Evli Bayan'
when e.TitleOfCourtesy='Ms.' then 'Bekar Bayan'
when e.TitleOfCourtesy='Mr.' then 'Erkek'
else
'Diðer'
end
from Employees e
