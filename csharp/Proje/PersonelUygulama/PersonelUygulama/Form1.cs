using PersonelUygulama.PersonelIslemleri;

namespace PersonelUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Temizle()
        {
            txtIsýnSoyisim.Clear();
            txtTC.Clear();
            txtTel.Clear();
            cboCinsiyet.SelectedIndex = 0;
            cboDepartman.SelectedIndex = 0;
            cboUnvan.SelectedIndex = 0;
            rctAdres.Clear();
            lblUyariTel.Visible = false;

        }



        PersonelManager personelManager=new PersonelManager();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Personel personel = new Personel();
                personel.TC = txtTC.Text;
                personel.IsimSoyisim = txtIsýnSoyisim.Text;
                personel.Adres = rctAdres.Text;
                personel.Departman = cboDepartman.Text;
                personel.Unvan = cboUnvan.Text;
                personel.Cinsiyet = cboCinsiyet.Text;
                personel.Tel = txtTel.Text;
                Temizle();
                personelManager.PersonelEkle(personel);
                PersonelListboxDoldur();
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen deðerleri kontrol ederek yeniden giriniz.");
            }
            
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
                

            personelManager.PersonelSil(listBox1.SelectedIndex);
            Temizle();
            listBox1.Items.Clear();
            PersonelListboxDoldur();

        }

        public void PersonelListboxDoldur()
        {
            listBox1.Items.Clear();
            List<Personel> personeller = new List<Personel>();
            personeller = personelManager.PersonelleriGetir();

            foreach (Personel personel_ in personeller)
            {
                listBox1.Items.Add(personel_.TC + " " + personel_.IsimSoyisim + " " + personel_.Cinsiyet + " " + personel_.Tel + " " + personel_.Departman + " " + personel_.Adres + " " + personel_.Unvan);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Temizle();
            PersonelListboxDoldur();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int secilenPersonelIndex = listBox1.SelectedIndex;
            Personel personel= personelManager.PersonelGetir(secilenPersonelIndex);
            personel.TC = txtTC.Text;
            personel.IsimSoyisim = txtIsýnSoyisim.Text;
            personel.Adres = rctAdres.Text;
            personel.Departman = cboDepartman.Text;
            personel.Unvan = cboUnvan.Text;
            personel.Cinsiyet = cboCinsiyet.Text;
            personel.Tel = txtTel.Text;
            personelManager.PersonelGuncelle(secilenPersonelIndex, personel);
            PersonelListboxDoldur();



        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            BilgileriEkranaYazdir();
        }

        public void BilgileriEkranaYazdir()
        {
            int secilenPersonelIndex = listBox1.SelectedIndex;
            Personel personel = personelManager.PersonelGetir(secilenPersonelIndex);
            txtTC.Text = personel.TC;
            txtIsýnSoyisim.Text= personel.IsimSoyisim;
            rctAdres.Text = personel.Adres;
            cboDepartman.Text = personel.Departman;
            cboUnvan.Text = personel.Unvan;
            cboCinsiyet.Text = personel.Cinsiyet;
            txtTel.Text = personel.Tel;
        }

        private void txtTel_Leave(object sender, EventArgs e)
        {
            if (txtTel.MaskCompleted == false)
            {
                lblUyariTel.Visible = true;
            }
            else
            {
                lblUyariTel.Visible=false;
            }
            
        }

        private void txtTC_Leave(object sender, EventArgs e)
        {

        }

        public void Kontrol(Form1 nesne)
        {
           
        }
    }
}