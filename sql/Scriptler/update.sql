--update
select * from FATURA_TBL_TEST2
update FATURA_TBL_TEST2
set KDV_DAHIL_TUTAR=KDV_DAHIL_TUTAR*0.18
where ID=2

------------------------------------------

use Northwind

select * from Products
select * from Categories where CategoryName='Beverages'

update Products 
set UnitsInStock=p.UnitsInStock+10
from Products p inner join Categories c
on p.CategoryID=c.CategoryID
where c.CategoryName='Beverages'

--Ms. Kadýn,Dr. Erkek, Mrs. Kadýn Mr. Erkek

alter table Employees
add bolge_kod varchar(50)


update Employees
set bolge_kod='TR'
WHERE EmployeeID BETWEEN 1 AND 7

UPDATE Employees 
SET TitleOfCourtesy=(CASE
WHEN emp.TitleOfCourtesy='Ms.'  THEN 'KADIN'
WHEN emp.TitleOfCourtesy='Mrs.'  THEN 'ERKEK'
ELSE 'ERKEK' END)
from Employees emp inner join
(
select ord.EmployeeID from Orders ord 
inner join Customers cms
on ord.CustomerID=cms.CustomerID
where YEAR(ord.OrderDate)>1996 and cms.City in('London','Stuttgart','Seattle','Kirkland','Salzburg')) xx 
on emp.EmployeeID=xx.EmployeeID
WHERE emp.bolge_kod='TR'

select * from Employees

