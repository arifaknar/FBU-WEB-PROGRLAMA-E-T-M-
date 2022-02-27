use Northwind

select * from Customers as c

select c.Address,c.City,c.CompanyName from Customers as c
select c.Address,c.City,c.CompanyName from Customers c--Unutulduðu ve kalabalýk yaratýldýðý için tablo isminden sonra isimlendirmeden sonra boþluk býrakýlýp adý yazýlýrsa alies olarak kabul eder.

select c.Region,c.City,C.Country,c.* from Customers as c with(nolock)

select top 1 c.* from Customers as c --1. veriyi alýr.

select top 25 percent c.* from Customers as c --percent bütün verilerin verilen yüzdekadar veri yi gösterir.

select top 20 percent c.Address from Customers as c --1. veriyi alýr.

select * from Employees as emp 
where emp.EmployeeID='7a' -- Ýçerisinde alfanumeric ifade varsa hata döndürür. Fakat alfanumeric ifadesi yoksa es geçebilir. 

--AND

select * from Employees as emp 
where LastName='Davolio' and LastName='Nancy'

--OR
select * from Employees as emp 
where LastName='Davolio' or TitleOfCourtesy='Mr.'

--IN VE NOT IN--
select * from Employees where EmployeeID in (5,8,9) -- EmployeeID si 5,8,9 olanlar gelir. Pratiktir ama performansý zayýftýr.
select * from Employees where EmployeeID not in (5,8,9)

--Ýs null null olan deðerleri döndürür. not is null tam tersi null olmayan deðerleri döndürür.
select emp.Region,emp.* from Employees emp where Region is Null 
select emp.Region,emp.* from Employees emp where Region is not Null

--OPERATÖRLER
-- <> Eþit Deðil
-- !< küçük deðildir
-- !> büyük deðildir

--Order Details
select ord.* from [Order Details] ord

--And
select ord.* from [Order Details] ord where ProductID>30 and Discount=0.05

--Or
select ord.* from [Order Details] ord where UnitPrice<=32.05 or UnitPrice>=80.40

--is null
select ord.* from [Order Details] ord where Discount is null

--<>
select ord.* from [Order Details] ord where Discount<>0

-- Percent
select top 20 percent ord.* from [Order Details] ord where Quantity!<25

--between
select o.ShipVia,o.* from Orders o
select o.ShipVia,o.* from Orders as o where o.EmployeeID between 1 and 10

select o.ShipName from Orders O WHERE o.ShipName like 'CO%'

select o.ShipName from Orders O WHERE o.ShipName like '%min%'

select o.* from Orders O WHERE o.Freight like '__.00'
select o.ShipName from Orders O WHERE o.ShipName like '[a,s]%' -- ilk harfi a ve s olanlarý alýr.
select o.ShipName from Orders O WHERE o.ShipName not like '[a,s]%' -- ilk harfi a ve s olmayanlarý.
select o.ShipName from Orders O WHERE o.ShipName  like '[a-d]%' -- ilk harfi a veya d olan.

--PRODUCTS

--Order By desc azalan -asc artan

select p.ProductID,p.CategoryID,p.SupplierID from Products p order by p.SupplierID desc --yada
select p.ProductID,p.CategoryID,p.SupplierID from Products p order by 3 asc 
select p.ProductID,p.CategoryID,p.SupplierID from Products p order by 1,3 asc 

--CUSTOMERS

select isnull(c.Region,'BOÞ')Region,c.* from Customers c

select isnull(c.Region,'BOÞ')Region,c.* from Customers c
where isnull(c.Region,'BOÞ')='BOÞ' -- bOÞ DEÐERLERÝN YERÝNE BOÞ YAZAR

SELECT COALESCE(C.Region,'BOÞ') from Customers C
SELECT COALESCE(C.Region,'BOÞ') AS COALSECE,isnull(c.Region,'BOÞ') AS ÝSNULL from Customers C --AYNILAR COALESCE ÝSNULL

SELECT COALESCE(C.Region,'BOÞ')+' '+isnull(c.Region,'BOÞ') AS ÝSNULLcOALSECE from Customers C

--NULL IF



select ISNULL(NULLIF(Fax,fax2),'Veri Tekrarý') from Customers -- nULL ÝF ÝKÝ KOLONU KARÞILAÞTIRIR VERÝ TEKRARI VARSA NULL DÖNER.

alter table Customers add fax2 nvarchar(50)
select COUNT(*) from Customers where NULLIF(Fax,fax2) is null










