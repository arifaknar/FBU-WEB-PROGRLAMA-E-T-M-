--try catch


declare @x int;
begin try
	select @x=1/0
end try

begin catch
select ERROR_MESSAGE() as [Hata Mesaj�],
ERROR_LINE() as [hata sat�r numaras�],
ERROR_STATE() as [hata durumu],
ERROR_NUMBER() as [Hata sql numaras�],
ERROR_SEVERITY() as [hata derecesi]
end catch
/*
Error_Severity() fonksiyonunda hata dereceleri a�a��daki gibidir.
0 veya 10 : Kullan�c� veri giri�inden kaynaklanan hatalar.
11-16 aras�: Kullan�c�n�n d�zeltebilece�i hatalar.
17 : Yetersiz kaynak hatalar� (Diskin dolu olmas� ya da tablonun salt okunur olmas� gibi)
18 : Yaz�l�mdan kaynaklanan hatalar.
19: K�s�tlay�clara tak�lan hata.
20-25 aras�: kritik hatalar
*/

begin try
	DELETE FROM Northwind.DBO.Orders WHERE OrderID=10248
end try

begin catch
	select ERROR_MESSAGE() as [Hata Mesaj�],
	ERROR_LINE() as [hata sat�r numaras�],
	ERROR_STATE() as [hata durumu],
	ERROR_NUMBER() as [Hata sql numaras�],
	ERROR_SEVERITY() as [hata derecesi]
end catch

--MEVCUT TABLOLARIMIZDAN HERHANG� B�R�N FARKLI B�R TABLOYA TRASFER� SONRASINDA OLU�AB�LECEK OLAN HATALARIN TRANSACT�ON LOG TABLOSUNA KAYDETME
use AdventureWorks20122
--ge�ici tabloya aktarma


CREATE TABLE #TransactionLog(logId int,LogTarih date,HataSatir int,HataDerecesi smallint,HataMesaj VARCHAR(200),HataDurum varchar(50))

alter table #TransactionLog alter column HataTuru varchar(650)
alter table #TransactionLog alter column LogTarih datetime
select * from #TransactionLog

declare @hataTuru nvarchar(550);

BEGIN TRY
	select * into  #EmployeeDeparment FROM HumanResources.EmployeeDepartmentHistorY
END TRY
BEGIN CATCH
	set @hataTuru ='select * into  #EmployeeDeparment FROM HumanResources.EmployeeDepartmentHistorY';
	insert into #TransactionLog(logId,LogTarih,HataSatir,HataDerecesi,HataMesaj,HataDurum,HataTuru) values(ERROR_NUMBER(),GETDATE(),ERROR_LINE(),ERROR_SEVERITY(),ERROR_MESSAGE(),ERROR_STATE(),@hataTuru)
	PRINT 'hATA alg�land� ve logland�: '+CAST(ERROR_MESSAGE() AS VARCHAR(200))

END CATCH


select * from #EmployeeDeparment

declare @hataTuru nvarchar(550);

BEGIN TRY
	update #EmployeeDeparment  set DepartmentID=250  where DepartmentID=5000
END TRY
BEGIN CATCH
	insert into #TransactionLog(logId,LogTarih,HataSatir,HataDerecesi,HataMesaj,HataDurum,HataTuru) values(ERROR_NUMBER(),GETDATE(),ERROR_LINE(),ERROR_SEVERITY(),ERROR_MESSAGE(),ERROR_STATE(),'update #EmployeeDeparment  set DepartmentID=250  where DepartmentID=3')
	PRINT 'hATA alg�land� ve logland�: '+CAST(ERROR_MESSAGE() AS VARCHAR(200))	
END CATCH





