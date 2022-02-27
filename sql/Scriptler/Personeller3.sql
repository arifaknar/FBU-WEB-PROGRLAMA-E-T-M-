/*Prosedür oluþturma*/
create proc spPersonelSayisiGetir @PersonelSayisi int output as begin select @PersonelSayisi=COUNT(PersonelId) from Personeller end

declare @PersonelSayisi int exec spPersonelSayisiGetir @PersonelSayisi output
Select @PersonelSayisi as "Personel Sayisi"