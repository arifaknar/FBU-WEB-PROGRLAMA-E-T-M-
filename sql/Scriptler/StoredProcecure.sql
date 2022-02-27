--�� yapar. Sql 1 kez derler hata olmazsa arka planda g�mer i�lemi ve onu kullanman� sa�lar.
--performansl�d�rlar. Network trafi�inde y�k� azalt�rlar. geri d�nd�rebilir ve ya d�nd�rmez.
/*
--K�sa ad� sp dir.
--Sakl� yordamlar olarak litaret�rde ge�er.
-T sql server programlama birimcikleridir.
-Paramerte alabilir ve geriye parametre d�nebilir.
-H�z,g�venlikperformans saplar. �� y�k� azalt�r.
-Network trafi�ini performansl� hale getirir.
-View ler gibi geriye select d�nebilir fakat sp lerde sql kullanaca��m�z zellikler fazlad�r.
-Fonksiyondan en �nemli fark� fonksiyon geriye de�er d�nmek zorundad�r ve fonksiyonun temel amac� dml de�ildir. sp de bu durum tam tersidir.
--�simlendirmede Sp_[ProcedureName] olarak i�aretlenir. 
--Parametreler @P_[PARAMETRENAME] �eklinde yaz�lmal�.
--RETURN verilmez Output kullan�l�r.
*/



CREATE DATABASE SP_DB
USE SP_DB
GO
--		procedure kullan�m�
CREATE PROCEDURE SP_YAZIMSEKLI(@P_PARAMETRE INT)
AS
BEGIN
	PRINT 'ILK SP CALISTI';
END

--PROCEDURE iki �ekilde �al��t�r�l�r. Execute,exec ya da object explorer dan manuel olarak(son i�lem tavsiye edilmez) �al��t�r�l�r. 

--1 Execute ile
EXECUTE SP_YAZIMSEKLI 1

--2 EXEC �LE
EXEC SP_YAZIMSEKLI 1

--PROCEDURE �ZER�NDE DE����KL�K YAPMA
--1 ALTER KOMUTU �LE

ALTER PROCEDURE SP_YAZIMSEKLI(@P_PARAMETRE INT,@P_PARAMETRE2 INT)
AS
BEGIN
	PRINT 'ILK SP CALISTI';
END

EXEC SP_YAZIMSEKLI 1,2

--2 MODIFY YA DA ALTER SCRIPT �LE
--PROCEDURE E SA� TIKLA MODIFY

