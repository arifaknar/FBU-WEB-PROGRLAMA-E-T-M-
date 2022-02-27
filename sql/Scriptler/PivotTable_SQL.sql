--P�VOT TABLE
--sat�rlar� s�tun olarak kullanmaya yarar.
-- istatiksel analiz yapmada �ok s�k kullan�l�r.

create table tbl_satis(
id int,
musteri varchar(50),
urun varchar(50),
tutar int,
ay varchar(50)
)

declare @raporTip varchar(50);
declare @raporId int=ceiling(rand()*3);
set @raporTip=case 
when @raporId=1 then 'Pivot'
when @raporTip=2 then 'UnPivot'
else  'Satis Raporu �cmal ' end

if(@raporTip='Pivot')

	begin
		select * from (
			select musteri,ay,sum(tutar) toplamSatis from tbl_satis
			group by musteri,ay
			) as satis_tablosu
	pivot
			(
			sum(toplamSatis)
				for ay in ([Ocak],[�ubat],[Mart],[Nisan]) -- kolon bazl� uygulama
				) as pvt
	end


else if(@raporTip='UnPivot')

	begin

		select musteri,ay,toplamSatis from (
		select musteri,ay,sum(tutar) toplamSatis from tbl_satis
		group by musteri,ay) as satis_tablosu
		pivot
		(
		sum(toplamSatis)
		for ay in ([Ocak],[�ubat],[Mart],[Nisan]) -- kolon bazl� uygulama
		) as pvt
		unpivot
		(
		toplamSatis
		for ay in ([Ocak],[�ubat],[Mart],[Nisan])
		) as un_pvt
	end

else
	begin
		select musteri,ay,sum(tutar) toplamSatis from tbl_satis
		group by musteri,ay
end


--Soru-- Toplam sat�� tutarlar�n�n y�l ve aylara g�re da��l�m�n� g�steren tablo


select * from 
(
select sum(sl.LineTotal) as toplamSatis,YEAR(sl.ModifiedDate) as Y�l, MONTH(sl.ModifiedDate) as Ay 
from Sales.SalesOrderDetail sl
group by  YEAR(sl.ModifiedDate), MONTH(sl.ModifiedDate)

) as Sales
pivot
(
		sum(toplamSatis)
		for Ay in ([1],[2],[3],[4],[5],[6],[7],[8],[9],[10],[11],[12])
		
) as pvt


--upivot evde bak.



