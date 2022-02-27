using System.Text;

namespace Metod3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1=int.Parse(textBox1.Text);
            int sayi2=int.Parse(textBox2.Text);
            string islem = comboBox1.Text;
            IslemYap(sayi1, sayi2, islem);
            label1.Text=sonuc.ToString();

        }

        int sonuc = 0;
        int sonuc2=0;
        void IslemYap(int sayi1,int sayi2,string islem)
        {
            try
            {
                
                switch (islem)
                {
                    case "+":
                        sonuc = sayi1 + sayi2;
                        sonuc2 = sonuc;
                        break;
                    case "-":
                        sonuc = sayi1 - sayi2;
                        sonuc2 = sonuc;
                        break;
                    case "/":
                        sonuc = sayi1 / sayi2;
                        sonuc2 = sonuc;
                        break;
                    case "*":
                        sonuc = sayi1 * sayi2;
                        sonuc2 = sonuc; 
                        break;

                }

            }
            catch (Exception)
            {

                throw;
            }




        }

        void SinirsizParametreParams(params int[] sayilar) // bu þekilde params ile oluþturulan metodlar istenilen kadar paramtre alýr.
        {
            sonuc = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                sonuc=sonuc + sayilar[i];
            }
            MessageBox.Show(sonuc.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SinirsizParametreParams(5, 78, 63, 52, 45, 14, 25, 68, 76, 85, 49, 24, 31, 56, 78, 74);
        }

        StringBuilder stringBuilder = new StringBuilder();
        void SinirsizParametreParams2(params string[] girdi) // bu þekilde params ile oluþturulan metodlar istenilen kadar paramtre alýr.
        {
            sonuc = 0;
            for (int i = 0; i < girdi.Length; i++)
            {
                stringBuilder.Append(girdi[i]);
                stringBuilder.Append(" ");

            }
            MessageBox.Show(stringBuilder.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SinirsizParametreParams2("fenerbahçe", "üniversitesi", "ataþehir", "istanbul");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                int not1 = 0, not2 = 0, not3 = 0;
                string isim = "";
                not1 = int.Parse(textBox4.Text);
                not2 = int.Parse(textBox3.Text);
                not3= int.Parse(textBox5.Text);
                isim = textBox6.Text;
                Dictionary<int,int> notlar=new Dictionary<int,int>();



                notlar.Add(1, not1);
                notlar.Add(2, not2);
                notlar.Add(3, not3);
                NotlarýHesapla(isim, notlar);
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        void NotlarýHesapla(string isim,Dictionary<int,int> notlar)
        {
            int ortalama = Convert.ToInt32(notlar.Values.Average());
            listBox1.Items.Add("Ad Soyad" + "  " + "Not Ortalamasý");
            listBox1.Items.Add(isim + "           " + ortalama);
        }
        Dictionary<string, string> atamalar = new Dictionary<string, string>();
        void AskerlikAtama()
        {
            atamalar.Clear();
            listBox2.Items.Clear();
            

            string[] erkekler = { "ARÝF", "ONUR", "BORA", "MERT", "EMÝN", "FATÝH", "ALPER", "SÝNAN", "MUSTAFA", "YUNUS" };
            string[] sehirler = { "Þýrnak", "Batman", "Mardin" };
            Random Rnd=new Random();
            int sayac = 1;
            int i = 0;
            while ( i<(erkekler.Length-1))
            {
                int sehirIndex=Rnd.Next(0,3);
                int erkekIndex=Rnd.Next(0,10);
                string gelenSehir = sehirler[sehirIndex];
                string gelenErkek = erkekler[erkekIndex];
                int TekrarSehirSayi = atamalar.Values.Count(atama => atama == gelenSehir );
                if (TekrarSehirSayi < 3 && atamalar.ContainsKey(gelenErkek)==false)
                {
                    atamalar.Add(gelenErkek, gelenSehir);
                    sayac++;
                    i++;
                }
                else if(TekrarSehirSayi > 3 && atamalar.ContainsKey(gelenErkek) == false)
                {
                    while (TekrarSehirSayi < 3)
                    {
                        sehirIndex = Rnd.Next(0, 2);
                        gelenSehir = sehirler[sehirIndex];
                        erkekIndex = Rnd.Next(0, 10);
                        gelenErkek = erkekler[erkekIndex];
                        TekrarSehirSayi = atamalar.Values.Count(atama => atama == gelenSehir);
                    }
                    atamalar.Add(gelenErkek, gelenSehir);
                    sayac++;
                    i++;
                }

            }

            foreach (var item in atamalar)
            {
                if(item.Value is not null && item.Value !="")
                listBox2.Items.Add(item.Key+" "+item.Value);
            }

            foreach(var item in erkekler)
            {
                if (atamalar.Keys.Contains(item)==false)
                {
                    MessageBox.Show("Batýnýn Güzel bir iline atandýn ((: "+item);
                }
            }









        }

        private void button5_Click(object sender, EventArgs e)
        {

            AskerlikAtama();
        }
    }
}