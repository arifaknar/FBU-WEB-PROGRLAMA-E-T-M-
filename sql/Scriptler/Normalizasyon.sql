/*     --------------------Normalizasyon--------------------         
Sadece gerekli veriler tutulur.
Her tablonun bir i�i vard�r.
Ama� veritaban�n�  od�zg�n organizasyon hale getirmek.
Tekrar� en aza indirir.
Normalize edilmi� bir tablonun s�tununda bir kolon sadece bir defa tekrar edebilir. Birden fazla tekrar edilirse denormalizasyon olur.

k�smi ba��ml�l�k: Bir k�s�tlama olmadan veri girmek.

1.nf(Normal From)=Ayn� tablo i�inde bir kolon ba�ka bir tablonun bir kolonunda tekrar edemez.
Her kolonda bir de�er olmal�.
Her kolonda bir de�er olmal�.
Kolonlarda Null de�erler olmamal� ve ascii karakterler i�eremez.. Mutlaka de�erler olmal�.
Her sat�r e�siz bir anahtar�(id) si olmal�.

2nf: 1nf nin kurallar� ge�erlidir.
Her tablonun primary key i olmal�d�r.
Primary key d���nda bir id varsa Foreign Key olmal�d�r.Bu durum fonksiyonel ba��ml�l�kt�r.
Foreign key bir ks��tlay�c�d�r.

3nf:


*/