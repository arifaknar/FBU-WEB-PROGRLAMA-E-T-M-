--with table önemli=> kullanmadan önce baþka bir transaction varsa arkada ; ile kapatýlmalý ve go verilmelidir.

/* Þema mantýðý

erp
muhasebe db => hesap þemasý altlarýna þemalar koyulur.
stok db
*/
use AdventureWorks20122
go
with personel_table
as
(
select e.BusinessEntityID,e.BirthDate,e.JobTitle,edh.ModifiedDate,d.Name,
CONCAT(s.EndTime,' ',CONVERT(varchar,s.StartTime,8),' ',
CONVERT(varchar,s.EndTime,8)) shift_timr_bozuk from HumanResources.Employee e
inner join HumanResources.EmployeeDepartmentHistory edh
on e.BusinessEntityID=edh.BusinessEntityID
inner join HumanResources.Department d
on d.DepartmentID=edh.DepartmentID
inner join HumanResources.Shift s
on s.ShiftID=edh.ShiftID
)

select p2.FirstName+' '+p2.LastName,p.* from personel_table p
left join Person.Person p2
on p.BusinessEntityID=p2.BusinessEntityID

select * from HumanResources.EmployeeDepartmentHistory
select * from HumanResources.Shift
select * from HumanResources.Department