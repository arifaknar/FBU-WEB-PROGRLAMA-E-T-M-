--try catch


declare @x int;
begin try
	select @x=1/0
end try

begin catch
select ERROR_MESSAGE() as [Hata Mesajý],
ERROR_LINE() as [hata satýr numarasý],
ERROR_STATE() as [hata durumu],
ERROR_NUMBER() as [Hata sql numarasý],
ERROR_SEVERITY() as [hata derecesi]
end catch
/*
Error_Severity() fonksiyonunda hata dereceleri aþaðýdaki gibidir.
0 veya 10 : Kullanýcý veri giriþinden kaynaklanan hatalar.
11-16 arasý: Kullanýcýnýn düzeltebileceði hatalar.
17 : Yetersiz kaynak hatalarý (Diskin dolu olmasý ya da tablonun salt okunur olmasý gibi)
18 : Yazýlýmdan kaynaklanan hatalar.
19: Kýsýtlayýclara takýlan hata.
20-25 arasý: kritik hatalar
*/

begin try
	DELETE FROM Northwind.DBO.Orders WHERE OrderID=10248
end try

begin catch
	select ERROR_MESSAGE() as [Hata Mesajý],
	ERROR_LINE() as [hata satýr numarasý],
	ERROR_STATE() as [hata durumu],
	ERROR_NUMBER() as [Hata sql numarasý],
	ERROR_SEVERITY() as [hata derecesi]
end catch

--MEVCUT TABLOLARIMIZDAN HERHANGÝ BÝRÝN FARKLI BÝR TABLOYA TRASFERÝ SONRASINDA OLUÞABÝLECEK OLAN HATALARIN TRANSACTÝON LOG TABLOSUNA KAYDETME
use AdventureWorks20122
--geçici tabloya aktarma


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
	PRINT 'hATA algýlandý ve loglandý: '+CAST(ERROR_MESSAGE() AS VARCHAR(200))

END CATCH


select * from #EmployeeDeparment

declare @hataTuru nvarchar(550);

BEGIN TRY
	update #EmployeeDeparment  set DepartmentID=250  where DepartmentID=5000
END TRY
BEGIN CATCH
	insert into #TransactionLog(logId,LogTarih,HataSatir,HataDerecesi,HataMesaj,HataDurum,HataTuru) values(ERROR_NUMBER(),GETDATE(),ERROR_LINE(),ERROR_SEVERITY(),ERROR_MESSAGE(),ERROR_STATE(),'update #EmployeeDeparment  set DepartmentID=250  where DepartmentID=3')
	PRINT 'hATA algýlandý ve loglandý: '+CAST(ERROR_MESSAGE() AS VARCHAR(200))	
END CATCH





