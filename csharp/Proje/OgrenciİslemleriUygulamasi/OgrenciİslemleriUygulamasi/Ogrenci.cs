using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciİslemleriUygulamasi
{
    public class Ogrenci
    {
        private string ogrenciNo;
        private string ogrenciAdi;
        private string ders;
        private string sinif;
        private int not;
        private Dictionary<string, int> ogrenciNotlar = new Dictionary<string, int>();
        private Dictionary<Ogrenci,string> sinifOgrenci = new Dictionary<Ogrenci,string>();
        

        
        


        public string OgrenciNo { get { return ogrenciNo; } set { ogrenciNo = value; } }
        public string OgrenciAdi { get { return ogrenciAdi; } set { ogrenciAdi = value; } }
        public string Ders { get { return ders; } set { ders = value; } }
        public string Sinif { get { return sinif; } set { sinif = value; } }
        public int Not { get { return not; } set { not=value; } }
        public Dictionary<string, int> OgrenciNotlar { get { return ogrenciNotlar; } set { ogrenciNotlar = value; } }
        public Dictionary<Ogrenci, string> SinifOgrenci { get { return sinifOgrenci; } set {  sinifOgrenci=value; } }

    }
}
