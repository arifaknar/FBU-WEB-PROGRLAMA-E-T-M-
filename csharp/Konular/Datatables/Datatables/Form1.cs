using System.Data;

namespace Datatables
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
             Data Table
            * Excel ile ayn� yap�dad�r. Va hatta ba�land��� veritaban� n�n tablo yap�s� ile ayn� yap�ya b�r�n�r. Sat�r ve s�tunlar olu�ur.
            * Veri taban� select sorgular�n�n d�nen de�erlerini i�ersinde
            * bar�nd�r�rlar. Ram i�inde olduk�a maaliyetlidir.
            * win form,adp.net ,console,web.api lerde �ok s�k kullan�l�rlar.
            * �zerinde linq sorgusu yaz�labilir.
            * Kullan�m� ve y�netimi olduk�a basittir.
             */


            DataTable dt = new DataTable("Stoklar"); // datatable ad�
            dt.Columns.Add(new DataColumn("StokId", typeof(int))); // datatable colon ad�
            dt.Columns.Add(new DataColumn("Stok Ad�", typeof(string)));
            dt.Columns.Add(new DataColumn("Stok Miktar", typeof(int)));

            dt.Rows.Add(1,"Elma",10);//Dtatable nesnesine kolon s�ras�na g�re veri ekleme
            dt.Rows.Add(2, "Armut", 5);
            dt.Rows.Add(3, "Kiraz", 20);
            dt.Rows.Add(4, "Muz", 30);

            int toplam = 0,toplam2=0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                toplam += int.Parse(dt.Rows[i]["Stok Miktar"].ToString());
            }
            MessageBox.Show(toplam.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable("��RENC�LER"); // data table ad�
            dt.Columns.Add("Id", typeof(int)); // colum ad� ve t�r�n� belirleme
            dt.Columns.Add("AdSoyad", typeof(string));
            dt.Columns.Add("Yas", typeof(int));
            //Datatable �zerinde sql de oldu�u gibi �zellikler atama
            dt.Columns["AdSoyad"].Caption = "�sim"; //Kolon ad�n� de�i�tirme
            dt.Columns["AdSoyad"].AllowDBNull = false;//null ge�ilemez alan
            dt.Columns["Id"].AutoIncrement = true;//Otomatik artan de�er olsun
            dt.Columns["Id"].AutoIncrementSeed = 1;// ba�llang�� de�eri
            dt.Columns["Id"].AutoIncrementStep = 1;//art�� miktar�

            dt.PrimaryKey = new DataColumn[] { dt.Columns["Id"] }; /* e��siz primarykey alan� kolonunu belirtme*/
            DataRow dr= dt.NewRow(); /* Dta table t�r�nden bir row olu�turuyorum. dt.Row.Add ile kullanabilirken dikkat edilirse, Id de�erine bir atama yap�yorum. Nedeni AutoIncerement de�erinin true olmas�. ayn� zamanda AutoIncrementSeed ve AutoIncrementStep de�erlerinin verilmesi.. Bu �zelli�i biz sql de identity ve primary key �zelli�inden hat�rl�yoruz.*/

            dr["AdSoyad"] = "Arif Aknar";
            dr["Yas"] = 38;
            dt.Rows.Add(dr);
            //iK� �EK�LDE DATA OKUMASINI YAPAB�L�R�M. 1.y�NTEM
            var adSoyad=dt.Rows[0]["AdSoyad"].ToString();
            var yas = dt.Rows[0]["Yas"];

            //generic yap�d�r. Burada de�erleri field �zelli�i sayesinde generic olarak y�netebilirim.

            var adSoyad2 = dt.Rows[0].Field<string>("AdSoyad");
            var yas2 = dt.Rows[0].Field<int>("Yas");
            MessageBox.Show(adSoyad + " " + yas, "\n Birinci Y�ntem");
            MessageBox.Show(adSoyad2 + " " + yas2, "\n �kinci Y�ntem");
        }
    }
}