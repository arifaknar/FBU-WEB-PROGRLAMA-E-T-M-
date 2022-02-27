USE [Zomato]
GO

/****** Object:  Table [dbo].[FaturaTbl]    Script Date: 16.12.2021 16:06:24 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE FaturaTbl(
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FaturaNo] [nvarchar](50) NOT NULL,
	[Müþteri] [nchar](10) NULL,
	[Adres] [nvarchar](50) NULL,
	[Miktar] [int] NULL,
	[BirimFiyat] [int] NULL,
	[Tutar] [nchar](10) NULL
) ON [PRIMARY]
GO


select * into #FaturaTbl3 from FaturaTbl with(nolock) --Geçiçi Tablo Oluþturma
select * from #FaturaTbl3


