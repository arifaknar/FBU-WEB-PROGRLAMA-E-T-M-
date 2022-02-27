using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALISVERİS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double gunlukCiro= 0.00,hedefCiro=500.00;
        double sepetToplamTutar = 0.00;
        int urunKod;




        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            string durum = "";
            if (listBox1.SelectedIndex != -1) { 
                int seciliUrunIndeks = listBox1.SelectedIndex;
                listBox1.Items.RemoveAt(seciliUrunIndeks);
                sepetToplamTutar = sepetToplamTutar - Convert.ToDouble(cboFiyatlar.Items[seciliUrunIndeks]);
                lblSepetTutar.Text = sepetToplamTutar.ToString();
                cboFiyatlar.Items.RemoveAt(seciliUrunIndeks);
                durum = "Ürün başarılı bir şekilde silindi.";

            }
            else
            {
                durum = "Lütfen ürün silme işleminden önce bir ürün seçiniz.";
            }

            MessageBox.Show(durum);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BaslangıcDegerlereDon();
            Random rnd = new Random();
            urunKod = rnd.Next(1000, 9999);
            gunlukCiro = 0;
        }

        private void BaslangıcDegerlereDon()
        {
             lblCiroHedef.Text = hedefCiro.ToString();
            Temizle();
             listBox1.Items.Clear();
            cboFiyatlar.Items.Clear();
        }
        private void Temizle()
        {
            txtUrunAd.Text = "";
            txtUrunBirimTutar.Text = "0";
            txtUrunMiktar.Text = "0";
            cboIskonto.SelectedIndex = 0;
            cboKDV.SelectedIndex = 0;
            cboPersonelIndırimi.SelectedIndex = 0;
        }

        private void btnUrunYeniKayit_Click(object sender, EventArgs e)
        {    gunlukCiro = gunlukCiro+ sepetToplamTutar;
            if (gunlukCiro >= hedefCiro)
            {
                lblCiroSonucHaber.Text = "Tebrikler Hedeflenen Ciroya Ulaşıldı";
                lblCiroSonucHaber.Visible = true;

            }
            
            Random rnd = new Random();
            urunKod = rnd.Next(1000, 9999);
            
            lblGunlukCiro.Text =gunlukCiro.ToString();
            BaslangıcDegerlereDon();
            sepetToplamTutar = 0;
            lblSepetTutar.Text = sepetToplamTutar.ToString();

        }

        

        private void txtUrunMiktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

       

        private void txtUrunBirimTutar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            bool durumUrunIsmi = txtUrunAd.Text.Trim() == "" ? false : true;
            bool durumUrunMiktar = txtUrunMiktar.Text == "0" ? false : true;
            bool durumUrunBirimTutar = txtUrunBirimTutar.Text == "0" ? false : true;
            bool durumKdv = cboKDV.Text == "0" ? false : true;
            if (durumUrunBirimTutar && durumUrunIsmi && durumUrunMiktar && durumKdv)
            {
                double tutar = ((Convert.ToDouble(txtUrunMiktar.Text)) * (Convert.ToDouble(txtUrunBirimTutar.Text)));
                tutar = tutar + ((tutar * (Convert.ToDouble(cboKDV.Text))) / 100) + ((tutar * Convert.ToDouble(cboIskonto.Text)) / 100);
                
                sepetToplamTutar = tutar + sepetToplamTutar;
                lblSepetTutar.Text = sepetToplamTutar.ToString();
                listBox1.Items.Add(urunKod + " " + txtUrunAd.Text + " " + txtUrunBirimTutar.Text + " " + txtUrunMiktar.Text + " " + tutar);
                cboFiyatlar.Items.Add(tutar);
                MessageBox.Show(listBox1.Items[0].ToString());
                Temizle();
                
                
            }
            else
            {
                MessageBox.Show("Ürün eklemek için gerekli alanları doldurunuz.");
            }
        }
    }
}
