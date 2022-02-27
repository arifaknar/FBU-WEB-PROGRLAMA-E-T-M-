--tÜM ÝÞLEMLER GEÇÝCÝ TABLODA YAPILCAK.
SELECT * INTO #CustomersTest FROM Customers 
SELECT * INTO #OrdersTest FROM Orders
SELECT * INTO #ProductsTest FROM Products
SELECT * INTO #ProductsTest2 FROM Products
SELECT * INTO #SuppliersTest FROM Suppliers
SELECT * INTO #OrderDetailsTest FROM [Order Details]
SELECT * INTO #EmployeesTest FROM Employees

--1 FAKS NUMARASI OLMAYANLARA FAX NUMARASI ATAMA MÜÞTERÝ

update #CustomersTest 
set Fax='(171) 555-6750'
where #CustomersTest.Fax is null

select * from #CustomersTest 

--2 EN ÇOK SATIÞ YAPILAN 3 MÜÞTERÝ VE EN ÇOK SATIN ALMA YAPTIÜIM 3 MÜÞTERÝYE VÝP MÜÞTERÝ TANIMLAMASI YAPILMASI
select * from #CustomersTest
select * from #SuppliersTest
-- #SuppliersTest VE #CustomersTest TABLOLARINA VIP ALANI EKLEDÝK.
ALTER TABLE #CustomersTest
ADD VIP bit;
ALTER TABLE #SuppliersTest
ADD VIP bit;

-- #CustomersTest VIP ÝLERÝN NULL DEÐER OLANLARINA DEFAULT 0 ATADIK.
UPDATE #CustomersTest
SET VIP=0
WHERE VIP IS NULL;

-- #SuppliersTest VIP ÝLERÝN NULL DEÐER OLANLARINA DEFAULT 0 ATADIK.
UPDATE #SuppliersTest
SET VIP=0
WHERE VIP IS NULL;

--SONRA EN ÇOK SATIÞ YAPTIÐIM MÜÞTERÝLERÝMÝ BULDUM

select top 3  ct.CustomerID,Count (*) [Sipariþ Sayýsý],ct.VIP from #OrdersTest ot
inner join #CustomersTest ct
on ot.CustomerID=ct.CustomerID
group by ct.CustomerID,ct.VIP
order by Count (*) desc

--SONRA EN ÇOK SATIN ALMA YAPTIÐIM TEDARÝKÇÝLERÝMÝ BULDUM

select top 3  pt.SupplierID,st.VIP,Count (*) [Sipariþ Sayýsý] from #ProductsTest pt
inner join #SuppliersTest st
on pt.SupplierID=st.SupplierID
group by pt.SupplierID,st.VIP
order by Count (*) desc


-- EN ÇOK SATIN ALMA YAPTIÐIM ÝLK ÜÇ TEDARÝKÇÝME VIP TANIMLAMASI YAPMA

update #SuppliersTest 
set VIP=1
from #SuppliersTest st inner join (select top 3 pt.SupplierID,st.VIP AS VIP,Count (*) [Sipariþ Sayýsý] from #ProductsTest pt
inner join #SuppliersTest st
on pt.SupplierID=st.SupplierID
group by pt.SupplierID,st.VIP
order by Count (*) desc) ST2
on st.SupplierID=ST2.SupplierID where st.VIP=0

-- EN ÇOK SATIÞ YAPILAN ÝLK ÜÇ MÜÞTERÝME VIP TANIMLAMASI YAPMA

update #CustomersTest
set VIP=1
from #CustomersTest CT inner join (select top 3  ct.CustomerID,Count (*) [Sipariþ Sayýsý],ct.VIP from #OrdersTest ot
inner join #CustomersTest ct
on ot.CustomerID=ct.CustomerID
group by ct.CustomerID,ct.VIP
order by Count (*) desc) CT2
on CT.CustomerID=CT2.CustomerID where CT2.VIP=0



--3 TEDARÝKÇÝNÝN TEMÝN ETTÝÐÝM ÜRÜNLERDEN HÝÇ SATIÞ YAPILMAMIÞ ÜRÜNLERÝN SÝLÝNMESÝ 



SELECT * FROM #ProductsTest2
SELECT * FROM #OrdersTest

delete from #ProductsTest2
where ProductID=(select distinct ProductID from #ProductsTest2 --a tablosu
except -- a tablosunda bulunan b tablosunda bulunmayan kayýtlarý listeler
select  ProductID from #OrderDetailsTest)--b tablosu



--4 KATEGORÝ VE ÜRÜN SATIÞI OLMAYAN KAYITLARIN TEMÝZLENMESÝ



--5 EN ÇOK SATIÞ YAPAN PERSONELLERÝMÝN PERSORMANS PUANLAMASI 1 ÝLE 10 DÜÞÜK 11 ÝLE 40 ORTA 41 VE FAZLASI ÝYÝ OLARAK PUANLAMASI
select * from #OrdersTest
select * from #EmployeesTest

ALTER TABLE #EmployeesTest  
add PerformansPuanlamasi VARCHAR(50) -- sütun ekleme


ALTER TABLE #EmployeesTest 
ALTER COLUMN PerformansPuanlamasi NVARCHAR(50) -- sütun güncelleme

; -- sütun ekleme
UPDATE #EmployeesTest 
SET PerformansPuanlamasi=(CASE
WHEN xx.[Sipariþ Sayýsý] between 1 and 50 THEN 'Düþük'
WHEN  xx.[Sipariþ Sayýsý] between 50 and 100 THEN 'Orta'
WHEN xx.[Sipariþ Sayýsý] >= 101 THEN 'Ýyi'
ELSE 'Düþük' END)
from #EmployeesTest et inner join
(
select ot.EmployeeID,COUNT(ot.EmployeeID) [Sipariþ Sayýsý] from #OrdersTest ot
inner join #EmployeesTest et
on ot.EmployeeID=et.EmployeeID -- bu select içinde toplam sipariþ sayýlarýný bulduk.
group by ot.EmployeeID) xx 
on et.EmployeeID=xx.EmployeeID
where xx.[Sipariþ Sayýsý]>0