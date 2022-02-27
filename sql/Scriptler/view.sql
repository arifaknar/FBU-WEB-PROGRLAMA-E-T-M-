--view => En sýk raporlarda kullanýlýr. Sorguyu kýsaltýr. Obje olarak saklar.

-- VÝEW Ý DEÐÝÞTÝRMEK ÝÇÝN northwind>views>view tablosu> VÝEW TABLOSUNA SAÐ TIK > script_view_as> ALTER to> new_create_editor_window týkla açýlan sorgu dosyasýnda create view tablosu_adi yerini alter ile deðiþtir. sonra deðiþiklikleri yap.

create view vw_URUN_SATIS_MIKTARLARI -- view oluþturma
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


