--De�i�ken Olu�turma => declare @degisken_adi degisken_t�r�(boyutu) = value. Birden fazla de�i�ken i�in virg�l ile ayr�labilir.
--Declare. Set ve select ile de�er atamas� yap�labilir.


declare @ad varchar(50)='arif'
declare @ad2 varchar(50)

set @ad2='emir' -- set => de�i�kene de�er atar
select @ad2='emir2'

print  @ad+' '+@ad2 --��kt� �eklinde sonu� olarak yazd�r�r.
select @ad+' '+@ad2 -- tablo s�tun �eklinde sonucu verir.

declare @ortalamaFiyat money;
set @ortalamaFiyat=(select avg(UnitPrice) from [Order Details] where Quantity>10)
print convert(varchar(50),@ortalamaFiyat)
--birim fiyat,miktar,tutar,kdv tutar,kdv oran

declare @birimFiyat int,@miktar int,@tutar int,@kdvTutar int,@kdvOran int;
set @birimFiyat=10;
set @miktar=15;
set @kdvOran=18;

set @tutar =@birimFiyat*@miktar;
set @kdvTutar=(@tutar/100)*@kdvOran;


print 'Tutar: '+convert(varchar(50),@tutar) + 'Kdv Tutar: '+convert(varchar(50),@kdvTutar)+' Toplam Tutar: '+ convert(varchar(50),(@tutar+@kdvTutar))

--iki kdv 8- 18 olabilir. iki tane iskonto 10 -20  olabilir.

declare @birimFiyat int,@miktar int,@tutar int,@kdvTutar int,@kdvOran int,@kdvOranTip1 int, @kdvOranTip2 int,@iskonto int,@iskonto1 int,@iskonto2 int,@toplamTutar int, @kdvIskonto int;
set @birimFiyat=10;
set @miktar=15;
set @kdvOran=18;
set @kdvOranTip1=18;
set @kdvOranTip2=8;

set @tutar =@birimFiyat*@miktar;
set @kdvTutar=(@tutar/100)*@kdvOran;
set @iskonto=10;
select @kdvIskonto=CASE 
WHEN @kdvOran=18 and @iskonto=10 THEN 18-10
ELSE 0 END 
select @kdvIskonto



print 'Tutar: '+convert(varchar(50),@tutar) + 'Kdv Tutar: '+convert(varchar(50),@kdvTutar)+' Toplam Tutar: '+ convert(varchar(50),(@tutar+@kdvTutar))

select @kdvIskonto=CASE 
WHEN @kdvOran=18 and @iskonto=10 THEN 18-10
ELSE 'Bilinmiyor' END AS Cinsiyet