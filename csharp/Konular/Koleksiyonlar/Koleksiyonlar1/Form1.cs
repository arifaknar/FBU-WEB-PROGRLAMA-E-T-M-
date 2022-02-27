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
             *Dizilerle ayný amacý taþýyan birden fazla verilerimizi tutan ve yönetmemizi saðlayan yapýlardýr.
             *Deðer olarak obje tutar.
             *Opp de kullanýlan veri yapýlarýnýn baþýný çeker.
             *Dizilerde indexer içinde dizi boyutu verilirken koleksiyonlarda verilmez.
             *Diziler daha hýzlý çalýþýr.
             *Bazý koleksiyon tipleri, Arraylist, Dictionary, Hashtable,Queue,SortedList,Stack
             * using System.Collections sýnýfýný kullanýr.
             * Koleksiyonlara obje türünden deðer atandýðýndan veri tipi verilmek zorunda deðiliz.
             * Koleksiyonlarýn boyutuna count ile eriþilir.
             
             
             
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
                    String => "Bu ifade alfanümeriktir.",
                    int => "Bu ifade tam sayýdýr.",
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
            * Dictionary gibi key,value  ile çalýþýr.
            * Her türlü veri tipini saklar.(value ve referance olanlar dahil)
            * Veri depolama ve sunma sýrasýnda boxing ve unboxing gerçekleþir. Bu sebeple yavaþtýr.
            * Tip güvenli deðildir.
            * System.collections.generic
            * Dictionary den farký veri tipi verilmek zorunda deðil.
            * Hashtable nongeneric bir yapýdýr. Performans açýsýndan dezavatajlýdýr.
            * nontypesafe dir.(tip güvenli deðil)
            * Farklý kullanma þekilleri vardýr.
             
             */
            sehirler.Add("34", "ÝSTANBUL");
            sehirler.Add("44", "MALATYA");
            sehirler.Add("55", "SAMSUN");
            sehirler.Add("81", "DÜZCE");
            foreach (var item in sehirler.Keys)
            {
                MessageBox.Show(sehirler[item].ToString());
            }

        }
    }
}