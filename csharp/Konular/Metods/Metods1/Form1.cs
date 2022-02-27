using System.Collections;

namespace Metods1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Metotlar
        /*
        Metotlar

        * Programýn herhangi bir yerinde daha sonra kullanmak için oluþturulan ve belli bir iþi yapan programlama parçalarýdýr.
        * Prosedürel programlamanýn en önemli amaç konusudur.
        * Interfaceler, classlar vs yapý tasarlamak içindir.
        * Metotlar class içinde tanýmlanýr.
        * Metot içersinde metot oluþturulabilir ama tavsiye edilmez.
        * Metot tanýmlanýrken;
            1- Eriþim belirleyicisi verilir. Eðer bir eriþim belirleyicisi verilmemiþse o metot nameSpace içerisinde eriþilebilir. Default eriþim belirleyicisi private dýr.
            2- Metodun varsa geriye dönüþ tipi verilir.
            Yoksa void verilir.
            3- Metot adý verilir.
            4- Varsa parametresi verilir.
            5- sONRASINDA SCOPE LAR OLUÞTURULARAK ALGORÝTMÝK KODLAR YAZILIR.
            
            4 türde metot oluþtutulabilir.
                a-Geriye deðer döndüren
                b-Geriye deðer döndürmeyen
                c- Geriye deðer döndürmeyen parametre alan
                d- Geriye deðer döndüren parametre alan

        not: metod içerisinde break point ile ilerlemek için f11 kullanýlmalýdýr.
         
         
         */
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        ArrayList arrayList = new ArrayList();
        
        public void ArrayInsert3()
        {
            
            arrayList.Add("ARÝF");
            arrayList.Add(25);
            arrayList.Add(9F);
            arrayList.Add(new int[] {3,5,8,2});

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArrayInsert3();
            foreach (var i in arrayList)
            {
                MessageBox.Show(i.ToString());
            }
        }

        Hashtable hashtable = new Hashtable();
        public void ListeyeEkle()
        {
            listBox1.Items.Clear();
            hashtable.Clear();
            hashtable.Add("Müdür", "Emir");
            hashtable.Add("Bölüm", "Biliþim");
            hashtable.Add("Maaþ", 5000);
            foreach (var i in hashtable.Values)
            {

                listBox1.Items.Add(i.ToString());
            }


        }

        public void SayisalLoto()
        {
            Random rnd=new Random();
            string kolon = "";
            int sayi = 0;
            Dictionary<int,int> sayilar=new Dictionary<int,int>();
            int j = 0;
            while ( j < 36 )
                {
                    sayi = rnd.Next(1, 49);

                    if (sayilar.ContainsValue(sayi) == false)
                     {
                        sayilar.Add(j, sayi);
                        j++;
                    }

                }
            j = 0;
            foreach (var sayim in sayilar.Values)
            {
                kolon = kolon + " " + sayim;
                if (j == 6)
                {
                    listBox1.Items.Add(kolon);
                    j = 0;
                    kolon = "";
                }
                j++;

               
            }

            int[] yazilanSayilar =new int[3];
            int i = 0;
            while ( i < 3)
            {
                sayi = rnd.Next(1, 49);
                if (yazilanSayilar.Contains(sayi)==false)
                {
                    yazilanSayilar[i] = sayi;
                    listBox2.Items.Add(sayi);
                    i++;
                }
            }
            int sayac = 0;
            for (int l = 0; l < 3; l++)
            {
                if (sayilar.ContainsValue(yazilanSayilar[l]) == true)
                {
                    sayac++;
                }
            }

            if (sayac == 3)
            {
                MessageBox.Show("Tebrikler Sayýsal Lotoyu Tutturdunuz (:");
            }
            else
            {
                MessageBox.Show("Maalesef Sayýsal Lotoyu Tutturamadýnýz ):");
            }

                
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            
            SayisalLoto();
        }
    }
}