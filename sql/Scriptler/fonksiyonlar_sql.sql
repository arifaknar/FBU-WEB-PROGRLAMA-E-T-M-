--fonksiyonlar

--fonksiyonlar execute edilmez.
-- fonksiyon kullanılırken başına dbo ifadesi koyulur. (dbo.fonksiyonismi)
create function fn_toplam(@tablo varchar(50))
returns int
as
return (select count(*) from @tablo)
‐‐Test etmek için
select
* from dbo.fn_sipList(1


Create Function Fn_ToplamaYap(@sayi1 int,@sayi2 int)
Returns int
As
Begin
Declare @toplam int
Set @toplam = @sayi1+ @sayi2
return @toplam
End

select dbo.Fn_ToplamaYap(5,8)

--ornek northwind urunlere %x zam yap. 
--Fakat satışı yapılmayan ürünleri güncelleme. 
--En çok satış yapılan ürüne ise yüzde 10 üzerinden zam yap.
USE Northwind
DECLARE @maxId int=(SELECT MAX(ProductID) FROM Products)

DECLARE @counter int=1;
WHILE(@counter<=@maxId)
	BEGIN
	
	
	DECLARE @zam int=0;
		DECLARE @pId int=(select ProductID from Products where ProductID=@counter)
		DECLARE @fiyat money=(SELECT UnitPrice  FROM Products where ProductID=@counter)
		
		DECLARE @yeniFiyat money=0;
		IF(@counter=dbo.FN_MAX_PRODUCT())-- EĞER @COUNTER MAX_PRODUCT F
			BEGIN
				SET @yeniFiyat=dbo.FN_ZAM(10,@fiyat)
				SELECT @yeniFiyat
			END
		ELSE 
			BEGIN
				SET @yeniFiyat=dbo.FN_ZAM(30,@fiyat)
				SELECT @yeniFiyat
			END
		
		IF(@yeniFiyat>0)
		BEGIN
			UPDATE Products SET UnitPrice=@yeniFiyat WHERE ProductID=@counter
		END
		
	set @counter=@counter+1;
	END
	SELECT * FROM Products


--ZAM FONKSİYON	
CREATE FUNCTION FN_ZAM(@zam INT,@unitPrice money)
RETURNS money
BEGIN
	set @unitPrice=@unitPrice+((@unitPrice*@zam)/100)
RETURN @unitPrice
END
	
SELECT dbo.FN_ZAM(10,125.12)




--max satılan ürün
CREATE FUNCTION FN_MAX_PRODUCT()
RETURNS INT
AS
BEGIN

DECLARE @productId int;
seT @productId=(select xx.ProductID from (SELECT  ordDtl.ProductID, count(*) 
as SumProducts FROM [Order Details] ordDtl group by ordDtl.ProductID order by SumProducts desc  ) as xx)
return @productId
END


--Ornek Maaş Hesaplama Fonksiyonu
--çalıştığı gün,personel ıd, maaş, ilgili ay lazım hesaplama için.

CREATE FUNCTION FN_MAAS_HESAPLA(@CALISTIGI_GUN SMALLINT,@PERSONEL_ID INT,@AY INT)
	RETURNS INT
	AS
		BEGIN
			DECLARE @MAAS INT;
			DECLARE @NET_MAAS INT;
			SET @MAAS=(SELECT Maas FROM Employees WHERE EmployeeID=@PERSONEL_ID)
			SET @NET_MAAS=(@MAAS/30)*@CALISTIGI_GUN
			RETURN @NET_MAAS
		END

		SELECT dbo.FN_MAAS_HESAPLA(5,10,1) AYLIK_NET_MAAS, Maas Sabit_Maas FROM Employees 
		--BAK SONRA

--ORNEK KDV TUTAR FONKSİYON

CREATE FUNCTION FN_KDV_HESAPLA(@FIYAT DECIMAL,@KDV_ORAN INT)
RETURNS DECIMAL
	AS
		BEGIN
		SET @FIYAT=@FIYAT+(@FIYAT/100)*@KDV_ORAN
		RETURN @FIYAT
		END

		SELECT dbo.FN_KDV_HESAPLA(500,18)


		--NOT IF OBJECT_ID('HESAPLAR') IS NULL BUNU ARAŞTIR,SP_WHO2 FONKSİYONU

--ORNEK ORTALAMA SATIS FONKSİYONU

CREATE FUNCTION FN_ORTALAMA_SATIS(@EMP_ID INT)
RETURNS MONEY
AS
	BEGIN
		DECLARE @ORTALAMA_SATIS MONEY;
		SET @ORTALAMA_SATIS=(SELECT AVG(ODDTL.Quantity) FROM Orders O INNER JOIN [Order Details] ODDTL ON O.OrderID=ODDTL.OrderID
		WHERE EmployeeID=@EMP_ID
		)
		RETURN @ORTALAMA_SATIS
	END

SELECT  dbo.FN_ORTALAMA_SATIS(5)
















