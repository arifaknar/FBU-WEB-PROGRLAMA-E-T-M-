using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelUygulama.PersonelIslemleri
{
    public class PersonelManager:Personel
    {

        public void PersonelEkle(Personel personel)
        {
            PersonelListesi.Add(personel);
            MessageBox.Show("Personel Başarı ile Eklendi");
        }

        public void PersonelSil(int personelIndex)
        {
            PersonelListesi.RemoveAt(personelIndex);
            MessageBox.Show("Personel Başarı ile Silindi");
        }

        public List<Personel> PersonelleriGetir()
        {
            return PersonelListesi;

        }

        public Personel PersonelGetir(int personelIndex)
        {
            
            return PersonelListesi[personelIndex];

        }

        public void PersonelGuncelle(int personelIndex,Personel personel)
        {

            PersonelListesi[personelIndex] = personel;

        }

    }
}
