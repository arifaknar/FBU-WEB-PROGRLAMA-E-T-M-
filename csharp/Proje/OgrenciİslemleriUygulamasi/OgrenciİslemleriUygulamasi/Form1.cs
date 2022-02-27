namespace OgrenciİslemleriUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("Öğrenci No", 200);
            listView1.Columns.Add("Öğrenci Adı", 200);
            listView1.Columns.Add("Ders", 200);
            listView1.Columns.Add("Sınıf", 200);
        }
        OgrenciManager ogrenciManager = new OgrenciManager();
        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci();

            ogrenci.OgrenciNo=txtOgrenciNo.Text;
            ogrenci.OgrenciAdi=txtOgrenciAdi.Text;
            ogrenci.Ders=cboDers.Text;
            ogrenci.
            

               
        }
    }
}