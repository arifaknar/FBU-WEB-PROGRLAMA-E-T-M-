using System.Collections;

namespace Koleksiyonlar1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region Koleksiyonlar
            /*
             *Dizilerle ayn� amac� ta��yan birden fazla verilerimizi tutan ve y�netmemizi sa�layan yap�lard�r.
             *De�er olarak obje tutar.
             *Opp de kullan�lan veri yap�lar�n�n ba��n� �eker.
             *Dizilerde indexer i�inde dizi boyutu verilirken koleksiyonlarda verilmez.
             *Diziler daha h�zl� �al���r.
             *Baz� koleksiyon tipleri, Arraylist, Dictionary, Hashtable,Queue,SortedList,Stack
             * using System.Collections s�n�f�n� kullan�r.
             * Koleksiyonlara obje t�r�nden de�er atand���ndan veri tipi verilmek zorunda de�iliz.
             * Koleksiyonlar�n boyutuna count ile eri�ilir.
             
             
             
             */
            #endregion

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add("arif");
            arrayList.Add(25);
            arrayList.Add(new int[] { 1, 2, 3, 4 });
            foreach (var i in arrayList)
            {
                string mesaj = i switch
                {
                    String => "Bu ifade alfan�meriktir.",
                    int => "Bu ifade tam say�d�r.",
                    Array => "Bu ifade dizidir.",
                    _ => "Bu bir ifadedir"
                };
                MessageBox.Show(mesaj);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //  Dictionary<key tipi,value tipi> dic = new Dictionary<key tipi,value tipi >();
            Dictionary<string,string> dic = new Dictionary<string,string>();
            dic.Add("txt", "notepad.exe");
            dic.Add("jpg", "resimm.jpg");

            MessageBox.Show( dic["txt"]);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<object> list = new List<object>();
            object obj =  "1";
            object obj2 = 2;
            list.Add(obj);
            list.Add(obj2);
            foreach (var item in list)
            {
                MessageBox.Show(item.ToString());
            }
        }

        Hashtable sehirler=new Hashtable();
        private void button4_Click(object sender, EventArgs e)
        {
            /*
             Hashtable
            * Dictionary gibi key,value  ile �al���r.
            * Her t�rl� veri tipini saklar.(value ve referance olanlar dahil)
            * Veri depolama ve sunma s�ras�nda boxing ve unboxing ger�ekle�ir. Bu sebeple yava�t�r.
            * Tip g�venli de�ildir.
            * System.collections.generic
            * Dictionary den fark� veri tipi verilmek zorunda de�il.
            * Hashtable nongeneric bir yap�d�r. Performans a��s�ndan dezavatajl�d�r.
            * nontypesafe dir.(tip g�venli de�il)
            * Farkl� kullanma �ekilleri vard�r.
             
             */
            sehirler.Add("34", "�STANBUL");
            sehirler.Add("44", "MALATYA");
            sehirler.Add("55", "SAMSUN");
            sehirler.Add("81", "D�ZCE");
            foreach (var item in sehirler.Keys)
            {
                MessageBox.Show(sehirler[item].ToString());
            }

        }
    }
}