create database Zomato2 --Dtabase Create ��lemi
ON PRIMARY
(Name='Zomato2',filename='C:\Data\Zomato2.mdf',SIZE=5120MB,--
FILEGROWTH=1024KB)--
LOG ON
(
Name='Zomato2_LOG',filename='C:\Data\Zomato2.ldf',SIZE=2014KB,--
FILEGROWTH=10%-- D�SKTE FAZLADAN YER AYIRTIR.
)

create database Zomato3