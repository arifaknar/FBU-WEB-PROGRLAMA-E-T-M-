use Northwind

select * from Customers as c

select c.Address,c.City,c.CompanyName from Customers as c
select c.Address,c.City,c.CompanyName from Customers c--Unutuldu�u ve kalabal�k yarat�ld��� i�in tablo isminden sonra isimlendirmeden sonra bo�luk b�rak�l�p ad� yaz�l�rsa alies olarak kabul eder.

select c.Region,c.City,C.Country,c.* from Customers as c with(nolock)

select top 1 c.* from Customers as c --1. veriyi al�r.

select top 25 percent c.* from Customers as c --percent b�t�n verilerin verilen y�zdekadar veri yi g�sterir.

select top 20 percent c.Address from Customers as c --1. veriyi al�r.

select * from Employees as emp 
where emp.EmployeeID='7a' -- ��erisinde alfanumeric ifade varsa hata d�nd�r�r. Fakat alfanumeric ifadesi yoksa es ge�ebilir. 

--AND

select * from Employees as emp 
where LastName='Davolio' and LastName='Nancy'

--OR
select * from Employees as emp 
where LastName='Davolio' or TitleOfCourtesy='Mr.'

--IN VE NOT IN--
select * from Employees where EmployeeID in (5,8,9) -- EmployeeID si 5,8,9 olanlar gelir. Pratiktir ama performans� zay�ft�r.
select * from Employees where EmployeeID not in (5,8,9)

--�s null null olan de�erleri d�nd�r�r. not is null tam tersi null olmayan de�erleri d�nd�r�r.
select emp.Region,emp.* from Employees emp where Region is Null 
select emp.Region,emp.* from Employees emp where Region is not Null

--OPERAT�RLER
-- <> E�it De�il
-- !< k���k de�ildir
-- !> b�y�k de�ildir

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
select o.ShipName from Orders O WHERE o.ShipName like '[a,s]%' -- ilk harfi a ve s olanlar� al�r.
select o.ShipName from Orders O WHERE o.ShipName not like '[a,s]%' -- ilk harfi a ve s olmayanlar�.
select o.ShipName from Orders O WHERE o.ShipName  like '[a-d]%' -- ilk harfi a veya d olan.

--PRODUCTS

--Order By desc azalan -asc artan

select p.ProductID,p.CategoryID,p.SupplierID from Products p order by p.SupplierID desc --yada
select p.ProductID,p.CategoryID,p.SupplierID from Products p order by 3 asc 
select p.ProductID,p.CategoryID,p.SupplierID from Products p order by 1,3 asc 

--CUSTOMERS

select isnull(c.Region,'BO�')Region,c.* from Customers c

select isnull(c.Region,'BO�')Region,c.* from Customers c
where isnull(c.Region,'BO�')='BO�' -- bO� DE�ERLER�N YER�NE BO� YAZAR

SELECT COALESCE(C.Region,'BO�') from Customers C
SELECT COALESCE(C.Region,'BO�') AS COALSECE,isnull(c.Region,'BO�') AS �SNULL from Customers C --AYNILAR COALESCE �SNULL

SELECT COALESCE(C.Region,'BO�')+' '+isnull(c.Region,'BO�') AS �SNULLcOALSECE from Customers C

--NULL IF



select ISNULL(NULLIF(Fax,fax2),'Veri Tekrar�') from Customers -- nULL �F �K� KOLONU KAR�ILA�TIRIR VER� TEKRARI VARSA NULL D�NER.

alter table Customers add fax2 nvarchar(50)
select COUNT(*) from Customers where NULLIF(Fax,fax2) is null










