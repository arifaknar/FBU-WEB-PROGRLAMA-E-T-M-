DROP DATABASE Zomato3-- Veritaban� silme

--Database i�in a�a��daki i�lem yap�l�rsa her �ey ra�men ve engellemelere ra�men silinir.
use master
go
alter database Zomato2 set single_user with
rollback immediate
use master 
go 
drop database Zomato2;