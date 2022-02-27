ALTER TABLE MUHASEBE_FIS_TBL
ADD CONSTRAINT QU_TAKIP_NO
UNIQUE (TAKIP_NO)

alter table MUHASEBE_FIS_TBL
ADD CONSTRAINT CHK_FIS_TARIHI
CHECK (FIS_TARIHI>GETDATE())

alter table MUHASEBE_FIS_TBL
ADD CONSTRAINT CHK_AC�KLAMA
CHECK (LEN(AC�KLAMA)>19)

alter table MUHASEBE_FIS_TBL
ADD CONSTRAINT DF_AKTIF_MI --CONSTRAINT ADI
DEFAULT '1'
FOR AKTIF_MI -- DEFAULT UYGULANAN S�TUN

alter table MUHASEBE_FIS_TBL
ADD CONSTRAINT DF_ONAY_DURUMU --CONSTRAINT ADI
DEFAULT '1'
FOR ONAY_DURUMU --

CREATE TABLE FATURA(
FATURA_ID int primary key identity(1,1),
FATURA_ADI VARCHAR(50))

ALTER TABLE MUHASEBE_FIS_TBL
ADD CONSTRAINT FK_FATURA_ID
FOREIGN KEY (FATURA_NO)
REFERENCES FATURA(FATURA_ID)

BACKUP DATABASE MuhasabeDb
TO DISK = 'C:\Users\arif.aknar\Desktop\FBU Sql Scriptler\MuhasabeDb.bak';
