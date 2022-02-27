namespace Metod_Ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int toplamFiyat = 0,
            toplamKdvFiyat = 0,
            toplamKdvliFiyat = 0,
            netTutarr = 0
            ;
        string urun;
        int urunAdeti;
        int iskonto;
        int urunFiyat;

        private void button1_Click(object sender, EventArgs e)
        {
            toplamFiyat = 0;
            toplamKdvFiyat = 0;
            toplamKdvliFiyat = 0;
            netTutarr = 0;

            urun = cboUrunAd.Text;
            urunAdeti=int.Parse(txtUrunAdet.Text);
            iskonto = int.Parse(cboIskonto.Text);
            urunFiyat = int.Parse(txtUrunFiyat.Text);

            ToplamFiyat();
            ToplamKdvFiyat();
            KdvDahilToplamFiyat();
            NetTutar();

            


        }

        private void cboUrunAd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void ToplamFiyat()
        {
            toplamFiyat = urunAdeti * urunFiyat;
            toplamFiyat = toplamFiyat - ((toplamFiyat * iskonto) / 100);
            txtToplamFiyat.Text = toplamFiyat.ToString();

        }

        public void ToplamKdvFiyat()
        {
            toplamKdvFiyat = cboUrunAd.Text switch
            {
                "Bilgisayar" => (toplamFiyat * 18)/100,
                "Mouse" => (toplamFiyat * 8) / 100,
                "Mönitör" => (toplamFiyat * 18) / 100,
                "Klavye" => (toplamFiyat * 10) / 100,
                "Kulaklýk" => (toplamFiyat * 12) / 100

            };

            txtKdvFiyat.Text = toplamKdvFiyat.ToString();
        }

        public void KdvDahilToplamFiyat()
        {
            toplamKdvliFiyat = toplamFiyat + toplamKdvFiyat;
            txtKdvDahilFiyat.Text = toplamKdvliFiyat.ToString();

        }

        public void NetTutar()
        {
            netTutar.Text = toplamKdvliFiyat.ToString();

        }
    }
}