--Ýþ yapar. Sql 1 kez derler hata olmazsa arka planda gömer iþlemi ve onu kullanmaný saðlar.
--performanslýdýrlar. Network trafiðinde yükü azaltýrlar. geri döndürebilir ve ya döndürmez.
/*
--Kýsa adý sp dir.
--Saklý yordamlar olarak litaretürde geçer.
-T sql server programlama birimcikleridir.
-Paramerte alabilir ve geriye parametre dönebilir.
-Hýz,güvenlikperformans saplar. Ýþ yükü azaltýr.
-Network trafiðini performanslý hale getirir.
-View ler gibi geriye select dönebilir fakat sp lerde sql kullanacaðýmýz zellikler fazladýr.
-Fonksiyondan en önemli farký fonksiyon geriye deðer dönmek zorundadýr ve fonksiyonun temel amacý dml deðildir. sp de bu durum tam tersidir.
--Ýsimlendirmede Sp_[ProcedureName] olarak iþaretlenir. 
--Parametreler @P_[PARAMETRENAME] þeklinde yazýlmalý.
--RETURN verilmez Output kullanýlýr.
*/



CREATE DATABASE SP_DB
USE SP_DB
GO
--		procedure kullanýmý
CREATE PROCEDURE SP_YAZIMSEKLI(@P_PARAMETRE INT)
AS
BEGIN
	PRINT 'ILK SP CALISTI';
END

--PROCEDURE iki þekilde çalýþtýrýlýr. Execute,exec ya da object explorer dan manuel olarak(son iþlem tavsiye edilmez) çalýþtýrýlýr. 

--1 Execute ile
EXECUTE SP_YAZIMSEKLI 1

--2 EXEC ÝLE
EXEC SP_YAZIMSEKLI 1

--PROCEDURE ÜZERÝNDE DEÐÝÞÝKLÝK YAPMA
--1 ALTER KOMUTU ÝLE

ALTER PROCEDURE SP_YAZIMSEKLI(@P_PARAMETRE INT,@P_PARAMETRE2 INT)
AS
BEGIN
	PRINT 'ILK SP CALISTI';
END

EXEC SP_YAZIMSEKLI 1,2

--2 MODIFY YA DA ALTER SCRIPT ÝLE
--PROCEDURE E SAÐ TIKLA MODIFY

