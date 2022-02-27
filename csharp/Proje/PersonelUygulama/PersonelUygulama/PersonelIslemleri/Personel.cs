using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelUygulama
{
    public class Personel
    {
        private string tc;
        private string isimSoyisim;
        private string departman;
        private string tel;
        private string adres;
        private string cinsiyet;
        private string unvan;
        private List<Personel> personelListesi=new List<Personel>();


        public string TC { get { return tc; } set { tc=value; } }
        public string IsimSoyisim { get { return isimSoyisim; } set { isimSoyisim= value; } }
        public string Departman { get { return departman; } set { departman = value; } }
        public string Tel { get { return tel; } set {  tel= value; } }
        public string Adres { get { return adres; } set {  adres= value; } }
        public string Cinsiyet { get { return cinsiyet; } set { cinsiyet= value; } }
        public string Unvan { get { return unvan; } set {  unvan= value; } }

        public List<Personel> PersonelListesi { get { return personelListesi; } set { personelListesi = value; } }
    }
}
