--ÝF ELSE ÝF ELSE
/*
if(kosul>0)
	begin
		if(kosul2>0)
			begin
			end
	end
else if
	begin
	end
else
	begin
	end
*/ 
--örnek 1
declare @sayi int=10;
if(@sayi>1)
	begin
	print 'Sayý 1 den büyüktür.'
	end
else
	begin 
	print 'Sayý 1 den küçüktür.'
	end

--örnek 2

declare @sayi1 int,@sayi2 int;
set @sayi1=5;
set @sayi2=10;

if(@sayi1>@sayi2)
	begin
	print'Sayý1 sayý2 den büyük.'
	end
else if(@sayi1=@sayi2)
	begin
	print'Sayý1 sayý2 e eþit.'
	end
else
begin
print 'Sayý1 sayý2 den küçük'
end

--ornek 3
declare @urun1 int=(
select sum(UnitPrice) from [Order Details] where ProductID=1
)

declare @urun2 int=(
select sum(UnitPrice) from [Order Details] where ProductID=2
)

if(@urun1>@urun2)
	begin
	print'urun1 urun2 den büyük.'
	end
else if(@urun1<@urun2)
	begin
	select ProductID,sum(UnitPrice) TOPLAMFIYAT from [Order Details] where ProductID in(1,2)
	GROUP BY ProductID
	end
else
begin
print 'urun1 urun2 eþit'
end

--ornek 4

declare @eminNot int =ceiling(rand()*100);
declare @cemilNot int =ceiling(rand()*100);
if(@eminNot>@cemilNot)
	begin
	print 'Emin Not : '+convert(varchar(50),@eminNot)+' Cemil Not :'+convert(varchar(50),@cemilNot)+' Eminin notu daha yüksek'
	end 
	

else if(@eminNot<@cemilNot)
	begin
	print 'Emin Not : '+convert(varchar(50),@eminNot)+' Cemil Not :'+convert(varchar(50),@cemilNot)+' Cemilin notu daha düþük'
	end
else
		begin
	print 'Emin Not : '+convert(varchar(50),@eminNot)+' Cemil Not :'+convert(varchar(50),@cemilNot)+' Notlar eþit'
	end

	--ornek5

declare @eminNot1 int =ceiling(rand()*100);
declare @cemilNot1 int =ceiling(rand()*100);
declare @eminNot2 int =ceiling(rand()*100);
declare @cemilNot2 int =ceiling(rand()*100);
declare @eminNot3 int =ceiling(rand()*100);
declare @cemilNot3 int =ceiling(rand()*100);
declare @OrtEmin int=(@eminNot1+@eminNot2+@eminNot3)/3;
declare @OrtCemil int=(@cemilNot1+@cemilNot2+@cemilNot3)/3;


declare @sinav1 varchar(50);
declare @sinav2 varchar(50);
declare @sinav3 varchar(50);

declare @sonDurum varchar(50);

--1.notlAR
if(@eminNot1>@cemilNot1)
	begin
	set @sinav1= 'Emin Not : '+convert(varchar(50),@eminNot1)+' Cemil Not :'+convert(varchar(50),@cemilNot1)+' Eminin 1.notu daha yüksek'
	end 
	

else if(@eminNot1<@cemilNot1)
	begin
	set @sinav1='Emin 1.Not : '+convert(varchar(50),@eminNot1)+' Cemil 2.Not :'+convert(varchar(50),@cemilNot1)+' Cemilin 1.notu daha yüksek'
	end
else
		begin
		set @sinav1='Emin 1.Not : '+convert(varchar(50),@eminNot1)+' Cemil 2.Not :'+convert(varchar(50),@cemilNot1)+'1.Notlar Eþit';
	end

	--2.notlAR
	if(@eminNot2>@cemilNot2)
	begin
	set @sinav2= 'Emin Not : '+convert(varchar(50),@eminNot2)+' Cemil Not :'+convert(varchar(50),@cemilNot2)+' Eminin 2.notu daha yüksek'
	end 
	

else if(@eminNot2<@cemilNot2)
	begin
	set @sinav2='Emin 1.Not : '+convert(varchar(50),@eminNot2)+' Cemil 2.Not :'+convert(varchar(50),@cemilNot2)+' Cemilin 2.notu daha yüksek'
	end
else
		begin
		set @sinav2='Emin 1.Not : '+convert(varchar(50),@eminNot2)+' Cemil 2.Not :'+convert(varchar(50),@cemilNot2)+'2.Notlar Eþit';
	end

	--3.notlAR

	if(@eminNot3>@cemilNot3)
	begin
	set @sinav3= 'Emin Not : '+convert(varchar(50),@eminNot3)+' Cemil Not :'+convert(varchar(50),@cemilNot3)+' Eminin 2.notu daha yüksek'
	end 
	

else if(@eminNot3<@cemilNot3)
	begin
	set @sinav3='Emin 1.Not : '+convert(varchar(50),@eminNot3)+' Cemil 2.Not :'+convert(varchar(50),@cemilNot3)+' Cemilin 2.notu daha yüksek'
	end
else
		begin
		set @sinav3='Emin 1.Not : '+convert(varchar(50),@eminNot3)+' Cemil 2.Not :'+convert(varchar(50),@cemilNot3)+'2.Notlar Eþit';
	end

	--sondurum
	if(@OrtEmin>@OrtCemil)
	begin
	set @sonDurum= 'Emin Genel Not: '+convert(varchar(50),@OrtEmin)+' Cemil Genel Not:'+convert(varchar(50),@OrtCemil)+' Eminin genel ortalamasý daha yüksek'
	end 
	

else if(@OrtEmin<@OrtCemil)
	begin
	set @sonDurum= 'Emin Genel Not: '+convert(varchar(50),@OrtEmin)+' Cemil Genel Not:'+convert(varchar(50),@OrtCemil)+' Cemilin genel ortalamasý daha yüksek'
	end
else
		begin
		set @sonDurum= 'Emin Genel Not: '+convert(varchar(50),@OrtEmin)+' Cemil Genel Not:'+convert(varchar(50),@OrtCemil)+'Genel ortalamalar Eþit';
	end

	select @sinav1+' '+@sinav2+' '+@sinav3+' '+@sonDurum 

--ornek 6

use AdventureWorks20122

declare @AvgWeight Decimal(8,2),@BikeCount int;

if((select count(*) from Production.Product where name like 'Touring-3000%')>5)
	begin
		set @BikeCount =
		(
		select count(*) from Production.Product
		where Name like 'Touring-3000%');
		
		set @AvgWeight =(select AVG(Weight) from Production.Product
		where Name like 'Touring-3000%');

		print 'They are '+ cast(@BikeCount as varchar(50))+' Touring-3000 bikes.'
		print 'The average weight of the top 5 Touring-3000 vikes is '+ Cast(@AvgWeight as varchar(8))+'.'
	end
else
	begin
	set @AvgWeight=(
	select avg(Weight) from Production.Product
	where name like 'Touring-3000%');
	print 'Average weight of the Touring-3000 bikes is '+cast(@AvgWeight as varchar(8))+'.'
	end;
go

	
