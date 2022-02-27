-- TABLO RETURN EDEN FONKSIYONLAR

CREATE FUNCTION FN_TABLO_DOLDUR(@PRODUCT_ID INT)
RETURNS @URUNLER TABLE
	(
	URUN_ID INT,
	URUN_AD NVARCHAR(40)
	)
	AS
	BEGIN
		INSERT INTO @URUNLER(URUN_ID,URUN_AD)
		SELECT ProductID,ProductName FROM Products WHERE ProductID=@PRODUCT_ID;
	RETURN;
	END;
	
SELECT * from dbo.FN_TABLO_DOLDUR(5)

--ornek calışanlar


USE [Northwind]
GO

/****** Object:  UserDefinedFunction [dbo].[FN_YAS_HESAPLA]    Script Date: 7.01.2022 18:14:11 ******/


CREATE FUNCTION FN_YAS_HESAPLA(@TARIH DATE)
RETURNS INT
AS
BEGIN
	DECLARE @YAS INT

	SET @YAS = CAST(DATEDIFF(YEAR, @TARIH, GETDATE()) AS INT)
	RETURN @YAS;
END



CREATE FUNCTION FN_TABLO_DOLDUR2(@DOGUM_TAR DATE)
RETURNS @CALISANLAR TABLE
(
ID INT,
AD VARCHAR(50),
SOYAD VARCHAR(50),
DEPARTMAN VARCHAR(50)
)
AS
	BEGIN
		INSERT INTO @CALISANLAR
		SELECT E.EmployeeID,E.FirstName,E.LastName,'MUHASEBE' as DEPARTMAN FROM Employees E 
		WHERE dbo.FN_YAS_HESAPLA(@DOGUM_TAR)>60
		RETURN
	END

	SELECT * FROM dbo.FN_TABLO_DOLDUR2('1960-12-08 00:00:00.000')
	

	--ORNEK 



CREATE FUNCTION FN_GetProductsScrapStatus(@ScrapComLevel INT)
RETURNS @ResultTable TABLE
(
	ProductName VARCHAR(50),
	ScrapQty FLOAT,
	ScrapReasonDef VARCHAR(100),
	ScrapStatus VARCHAR(50)
)
AS
BEGIN
	INSERT INTO @ResultTable
	SELECT PR.Name, SUM(ScrappedQty), SC.Name, NULL FROM Production.WorkOrder WO
		INNER JOIN Production.Product PR
		ON PR.ProductID = WO.ProductID
		INNER JOIN Production.ScrapReason SC
		ON SC.ScrapReasonID = WO.ScrapReasonID
	WHERE WO.ScrapReasonID IS NOT NULL
	GROUP BY PR.Name , SC.Name

	UPDATE @ResultTable
		SET ScrapStatus = 
		CASE WHEN ScrapQty > @ScrapComLevel THEN 'Critical'
		ELSE 'Normal' END

	RETURN
END

			
				
	