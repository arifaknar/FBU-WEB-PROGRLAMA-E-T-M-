using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciİslemleriUygulamasi
{
    public class OgrenciManager:Ogrenci
    {
        public void ekle(Ogrenci ogrenci)
        {
            if (SinifOgrenci.ContainsKey(ogrenci) == false && OgrenciNotlar.ContainsKey(ogrenci.OgrenciNo + ogrenci.Ders)==false)
            {
                SinifOgrenci.Add(ogrenci,ogrenci.Sinif);
                OgrenciNotlar.Add((ogrenci.OgrenciNo + ogrenci.Ders), ogrenci.Not);

                MessageBox.Show("Ekleme İşlemi Başarılı");
            } 
        }

        public void sil(Ogrenci ogrenci)
        {
            if (SinifOgrenci.ContainsKey(ogrenci) == true)
            {
                SinifOgrenci.Remove(ogrenci);
            }
            
        }
    }
}
