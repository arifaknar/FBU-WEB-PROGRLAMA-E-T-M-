USE AdventureWorks20122

SELECT * FROM HumanResources.Employee
SELECT * FROM HumanResources.EmployeeDepartmentHistory

-- 1.SORGU
select 
(select e.Gender from HumanResources.Employee e where e.BusinessEntityID = edh.BusinessEntityID) as cinsiyet,
(select CONCAT(p.FirstName,p.LastName,p.MiddleName,p.EmailPromotion) from Person.Person p where p.BusinessEntityID = edh.BusinessEntityID) aS genel_bilgi,
edh.ModifiedDate
from HumanResources.EmployeeDepartmentHistory edh
WHERE edh.EndDate IS NOT NULL

-- 2.SORGU

SELECT X1.CINSIYET,
X1.GENEL_BILGI,
EDH.ModifiedDate FROM HumanResources.EmployeeDepartmentHistory EDH
INNER JOIN
(SELECT P1.BusinessEntityID AS BusinessEntityID,
E.Gender CINSIYET,
CONCAT(P1.FirstName,P1.LastName,P1.MiddleName,P1.EmailPromotion) AS GENEL_BILGI
FROM Person.Person P1 INNER JOIN HumanResources.Employee E
ON P1.BusinessEntityID=E.BusinessEntityID) X1
ON EDH.BusinessEntityID=X1.BusinessEntityID
WHERE EDH.EndDate IS NOT NULL

SELECT YEAR(EPH2.RateChangeDate) as YIL,E.*  from HumanResources.Employee e
inner join HumanResources.EmployeePayHistory EPH2
on EPH2.BusinessEntityID=e.BusinessEntityID
where exists (select distinct YEAR(EPH.RateChangeDate)
FROM HumanResources.EmployeePayHistory EPH
WHERE e.BusinessEntityID=eph.BusinessEntityID 
and YEAR(EPH.RateChangeDate)>2002 )

--stuff('eklenenecek metin',baslanýc indeksi,bitis i.,'eklenecek metin')

select stuff('arif     a ',6,5,'aknar')
