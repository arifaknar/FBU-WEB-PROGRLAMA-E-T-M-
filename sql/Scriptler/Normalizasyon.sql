/*     --------------------Normalizasyon--------------------         
Sadece gerekli veriler tutulur.
Her tablonun bir iþi vardýr.
Amaç veritabanýný  odüzgün organizasyon hale getirmek.
Tekrarý en aza indirir.
Normalize edilmiþ bir tablonun sütununda bir kolon sadece bir defa tekrar edebilir. Birden fazla tekrar edilirse denormalizasyon olur.

kýsmi baðýmlýlýk: Bir kýsýtlama olmadan veri girmek.

1.nf(Normal From)=Ayný tablo içinde bir kolon baþka bir tablonun bir kolonunda tekrar edemez.
Her kolonda bir deðer olmalý.
Her kolonda bir deðer olmalý.
Kolonlarda Null deðerler olmamalý ve ascii karakterler içeremez.. Mutlaka deðerler olmalý.
Her satýr eþsiz bir anahtarý(id) si olmalý.

2nf: 1nf nin kurallarý geçerlidir.
Her tablonun primary key i olmalýdýr.
Primary key dýþýnda bir id varsa Foreign Key olmalýdýr.Bu durum fonksiyonel baðýmlýlýktýr.
Foreign key bir ksýýtlayýcýdýr.

3nf:


*/