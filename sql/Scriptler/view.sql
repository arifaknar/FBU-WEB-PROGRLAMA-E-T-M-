--view => En s�k raporlarda kullan�l�r. Sorguyu k�salt�r. Obje olarak saklar.

-- V�EW � DE���T�RMEK ���N northwind>views>view tablosu> V�EW TABLOSUNA SA� TIK > script_view_as> ALTER to> new_create_editor_window t�kla a��lan sorgu dosyas�nda create view tablosu_adi yerini alter ile de�i�tir. sonra de�i�iklikleri yap.

create view vw_URUN_SATIS_MIKTARLARI -- view olu�turma
AS
(select xx.ProductName,sum(xx.miktar) miktar_toplam from (
select p.Productname,
(select s.CompanyName from Suppliers s where s.SupplierID=p.SupplierID) as tedarikci,
o.Quantity miktar
from Products p inner join [Order Details] o
on o.ProductID=p.ProductID
) xx

group by xx.ProductName
having sum(xx.miktar) >200)


