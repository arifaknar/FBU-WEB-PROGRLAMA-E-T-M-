select * from Products

alter function fn_GetKategoriId_Product(@CategoryId int) --Parametreli fonksiyon. Ýlk oluþtururken create deðiþtirken alter kullanýlýr.
returns Table
as
return select ProductName,CategoryID,UnitPrice  
from Products where CategoryID=@CategoryId

select * from fn_GetKategoriId_Product(7)

create function fn_GetEmployees() --create new function 
returns Table
as
return(select * from Employees)

alter function fn_GetEmployees() --alter  function 
returns Table
as
return(select EmployeeID,FirstName,LastName from Employees)

select * from fn_GetEmployees()

create function ML_GetEmployees()
returns @Table Table (Id int,Ad nvarchar(50),Soyad  nvarchar(50))
as
begin
insert into @Table
select EmployeeID,FirstName,LastName from Employees
return
end

select * from ML_GetEmployees()

select CustomerID,CompanyName,ContactName,Country from Customers where Country in ('Spain','France','Germany')

select ProductName,UnitPrice from Products where ProductName Like 'C%' -- C ile baþlayan  ürünler

select CompanyName from Customers where CompanyName Like '%RESTAURANT%'

select ProductName,UnitPrice from Products where UnitPrice BETWEEN  50 AND 100 

select CompanyName from Customers where Fax  is null group by CompanyName 