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
            * Excel ile ayný yapýdadýr. Va hatta baðlandýðý veritabaný nýn tablo yapýsý ile ayný yapýya bürünür. Satýr ve sütunlar oluþur.
            * Veri tabaný select sorgularýnýn dönen deðerlerini içersinde
            * barýndýrýrlar. Ram içinde oldukça maaliyetlidir.
            * win form,adp.net ,console,web.api lerde çok sýk kullanýlýrlar.
            * Üzerinde linq sorgusu yazýlabilir.
            * Kullanýmý ve yönetimi oldukça basittir.
             */


            DataTable dt = new DataTable("Stoklar"); // datatable adý
            dt.Columns.Add(new DataColumn("StokId", typeof(int))); // datatable colon adý
            dt.Columns.Add(new DataColumn("Stok Adý", typeof(string)));
            dt.Columns.Add(new DataColumn("Stok Miktar", typeof(int)));

            dt.Rows.Add(1,"Elma",10);//Dtatable nesnesine kolon sýrasýna göre veri ekleme
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
            DataTable dt = new DataTable("ÖÐRENCÝLER"); // data table adý
            dt.Columns.Add("Id", typeof(int)); // colum adý ve türünü belirleme
            dt.Columns.Add("AdSoyad", typeof(string));
            dt.Columns.Add("Yas", typeof(int));
            //Datatable üzerinde sql de olduðu gibi özellikler atama
            dt.Columns["AdSoyad"].Caption = "Ýsim"; //Kolon adýný deðiþtirme
            dt.Columns["AdSoyad"].AllowDBNull = false;//null geçilemez alan
            dt.Columns["Id"].AutoIncrement = true;//Otomatik artan deðer olsun
            dt.Columns["Id"].AutoIncrementSeed = 1;// baþllangýç deðeri
            dt.Columns["Id"].AutoIncrementStep = 1;//artýþ miktarý

            dt.PrimaryKey = new DataColumn[] { dt.Columns["Id"] }; /* eþþsiz primarykey alaný kolonunu belirtme*/
            DataRow dr= dt.NewRow(); /* Dta table türünden bir row oluþturuyorum. dt.Row.Add ile kullanabilirken dikkat edilirse, Id deðerine bir atama yapýyorum. Nedeni AutoIncerement deðerinin true olmasý. ayný zamanda AutoIncrementSeed ve AutoIncrementStep deðerlerinin verilmesi.. Bu özelliði biz sql de identity ve primary key özelliðinden hatýrlýyoruz.*/

            dr["AdSoyad"] = "Arif Aknar";
            dr["Yas"] = 38;
            dt.Rows.Add(dr);
            //iKÝ ÞEKÝLDE DATA OKUMASINI YAPABÝLÝRÝM. 1.yÖNTEM
            var adSoyad=dt.Rows[0]["AdSoyad"].ToString();
            var yas = dt.Rows[0]["Yas"];

            //generic yapýdýr. Burada deðerleri field özelliði sayesinde generic olarak yönetebilirim.

            var adSoyad2 = dt.Rows[0].Field<string>("AdSoyad");
            var yas2 = dt.Rows[0].Field<int>("Yas");
            MessageBox.Show(adSoyad + " " + yas, "\n Birinci Yöntem");
            MessageBox.Show(adSoyad2 + " " + yas2, "\n Ýkinci Yöntem");
        }
    }
}