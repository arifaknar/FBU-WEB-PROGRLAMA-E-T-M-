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

        * Program�n herhangi bir yerinde daha sonra kullanmak i�in olu�turulan ve belli bir i�i yapan programlama par�alar�d�r.
        * Prosed�rel programlaman�n en �nemli ama� konusudur.
        * Interfaceler, classlar vs yap� tasarlamak i�indir.
        * Metotlar class i�inde tan�mlan�r.
        * Metot i�ersinde metot olu�turulabilir ama tavsiye edilmez.
        * Metot tan�mlan�rken;
            1- Eri�im belirleyicisi verilir. E�er bir eri�im belirleyicisi verilmemi�se o metot nameSpace i�erisinde eri�ilebilir. Default eri�im belirleyicisi private d�r.
            2- Metodun varsa geriye d�n�� tipi verilir.
            Yoksa void verilir.
            3- Metot ad� verilir.
            4- Varsa parametresi verilir.
            5- sONRASINDA SCOPE LAR OLU�TURULARAK ALGOR�TM�K KODLAR YAZILIR.
            
            4 t�rde metot olu�tutulabilir.
                a-Geriye de�er d�nd�ren
                b-Geriye de�er d�nd�rmeyen
                c- Geriye de�er d�nd�rmeyen parametre alan
                d- Geriye de�er d�nd�ren parametre alan

        not: metod i�erisinde break point ile ilerlemek i�in f11 kullan�lmal�d�r.
         
         
         */
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        ArrayList arrayList = new ArrayList();
        
        public void ArrayInsert3()
        {
            
            arrayList.Add("AR�F");
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
            hashtable.Add("M�d�r", "Emir");
            hashtable.Add("B�l�m", "Bili�im");
            hashtable.Add("Maa�", 5000);
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
                MessageBox.Show("Tebrikler Say�sal Lotoyu Tutturdunuz (:");
            }
            else
            {
                MessageBox.Show("Maalesef Say�sal Lotoyu Tutturamad�n�z ):");
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