DROP DATABASE Zomato3-- Veritabaný silme

--Database için aþaðýdaki iþlem yapýlýrsa her þey raðmen ve engellemelere raðmen silinir.
use master
go
alter database Zomato2 set single_user with
rollback immediate
use master 
go 
drop database Zomato2;