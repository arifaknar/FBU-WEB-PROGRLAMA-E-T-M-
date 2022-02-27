--t�M ��LEMLER GE��C� TABLODA YAPILCAK.
SELECT * INTO #CustomersTest FROM Customers 
SELECT * INTO #OrdersTest FROM Orders
SELECT * INTO #ProductsTest FROM Products
SELECT * INTO #ProductsTest2 FROM Products
SELECT * INTO #SuppliersTest FROM Suppliers
SELECT * INTO #OrderDetailsTest FROM [Order Details]
SELECT * INTO #EmployeesTest FROM Employees

--1 FAKS NUMARASI OLMAYANLARA FAX NUMARASI ATAMA M��TER�

update #CustomersTest 
set Fax='(171) 555-6750'
where #CustomersTest.Fax is null

select * from #CustomersTest 

--2 EN �OK SATI� YAPILAN 3 M��TER� VE EN �OK SATIN ALMA YAPTI�IM 3 M��TER�YE V�P M��TER� TANIMLAMASI YAPILMASI
select * from #CustomersTest
select * from #SuppliersTest
-- #SuppliersTest VE #CustomersTest TABLOLARINA VIP ALANI EKLED�K.
ALTER TABLE #CustomersTest
ADD VIP bit;
ALTER TABLE #SuppliersTest
ADD VIP bit;

-- #CustomersTest VIP �LER�N NULL DE�ER OLANLARINA DEFAULT 0 ATADIK.
UPDATE #CustomersTest
SET VIP=0
WHERE VIP IS NULL;

-- #SuppliersTest VIP �LER�N NULL DE�ER OLANLARINA DEFAULT 0 ATADIK.
UPDATE #SuppliersTest
SET VIP=0
WHERE VIP IS NULL;

--SONRA EN �OK SATI� YAPTI�IM M��TER�LER�M� BULDUM

select top 3  ct.CustomerID,Count (*) [Sipari� Say�s�],ct.VIP from #OrdersTest ot
inner join #CustomersTest ct
on ot.CustomerID=ct.CustomerID
group by ct.CustomerID,ct.VIP
order by Count (*) desc

--SONRA EN �OK SATIN ALMA YAPTI�IM TEDAR�K��LER�M� BULDUM

select top 3  pt.SupplierID,st.VIP,Count (*) [Sipari� Say�s�] from #ProductsTest pt
inner join #SuppliersTest st
on pt.SupplierID=st.SupplierID
group by pt.SupplierID,st.VIP
order by Count (*) desc


-- EN �OK SATIN ALMA YAPTI�IM �LK �� TEDAR�K��ME VIP TANIMLAMASI YAPMA

update #SuppliersTest 
set VIP=1
from #SuppliersTest st inner join (select top 3 pt.SupplierID,st.VIP AS VIP,Count (*) [Sipari� Say�s�] from #ProductsTest pt
inner join #SuppliersTest st
on pt.SupplierID=st.SupplierID
group by pt.SupplierID,st.VIP
order by Count (*) desc) ST2
on st.SupplierID=ST2.SupplierID where st.VIP=0

-- EN �OK SATI� YAPILAN �LK �� M��TER�ME VIP TANIMLAMASI YAPMA

update #CustomersTest
set VIP=1
from #CustomersTest CT inner join (select top 3  ct.CustomerID,Count (*) [Sipari� Say�s�],ct.VIP from #OrdersTest ot
inner join #CustomersTest ct
on ot.CustomerID=ct.CustomerID
group by ct.CustomerID,ct.VIP
order by Count (*) desc) CT2
on CT.CustomerID=CT2.CustomerID where CT2.VIP=0



--3 TEDAR�K��N�N TEM�N ETT���M �R�NLERDEN H�� SATI� YAPILMAMI� �R�NLER�N S�L�NMES� 



SELECT * FROM #ProductsTest2
SELECT * FROM #OrdersTest

delete from #ProductsTest2
where ProductID=(select distinct ProductID from #ProductsTest2 --a tablosu
except -- a tablosunda bulunan b tablosunda bulunmayan kay�tlar� listeler
select  ProductID from #OrderDetailsTest)--b tablosu



--4 KATEGOR� VE �R�N SATI�I OLMAYAN KAYITLARIN TEM�ZLENMES�



--5 EN �OK SATI� YAPAN PERSONELLER�M�N PERSORMANS PUANLAMASI 1 �LE 10 D���K 11 �LE 40 ORTA 41 VE FAZLASI �Y� OLARAK PUANLAMASI
select * from #OrdersTest
select * from #EmployeesTest

ALTER TABLE #EmployeesTest  
add PerformansPuanlamasi VARCHAR(50) -- s�tun ekleme


ALTER TABLE #EmployeesTest 
ALTER COLUMN PerformansPuanlamasi NVARCHAR(50) -- s�tun g�ncelleme

; -- s�tun ekleme
UPDATE #EmployeesTest 
SET PerformansPuanlamasi=(CASE
WHEN xx.[Sipari� Say�s�] between 1 and 50 THEN 'D���k'
WHEN  xx.[Sipari� Say�s�] between 50 and 100 THEN 'Orta'
WHEN xx.[Sipari� Say�s�] >= 101 THEN '�yi'
ELSE 'D���k' END)
from #EmployeesTest et inner join
(
select ot.EmployeeID,COUNT(ot.EmployeeID) [Sipari� Say�s�] from #OrdersTest ot
inner join #EmployeesTest et
on ot.EmployeeID=et.EmployeeID -- bu select i�inde toplam sipari� say�lar�n� bulduk.
group by ot.EmployeeID) xx 
on et.EmployeeID=xx.EmployeeID
where xx.[Sipari� Say�s�]>0