using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DegiskenlerUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double toplamTutar = 0,netTutar=0;
        int kdv = 0, iskonto = 0;

        private void btnYeniIslem_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Temizle()
        {
            txtMiktarArmut.Clear();
            txtMiktarElma.Clear();
            txtMiktarKiraz.Clear();
            txtMiktarMuz.Clear();
            txtMiktarPortakal.Clear();
            cboIskonto.SelectedIndex = 0;
            cboKdv.SelectedIndex = 0;
            cboFiyatArmut.SelectedIndex = 0;
            cboFiyatElma.SelectedIndex = 0;
            cboFiyatKiraz.SelectedIndex = 0;
            cboFiyatMuz.SelectedIndex = 0;
            cboFiyatPortakal.SelectedIndex = 0;
            lblKdv.Text = "";
            lblIskonto.Text = "";
            lblNetTutar.Text = "";
            lblToplamTutar.Text = "";
            lblHesaplamalarToplamTutar.Text = "";
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            
            (double adetElma, double adetArmut, double adetMuz, double adetKiraz, double adetPortakal) adetler = (Convert.ToDouble(txtMiktarElma.Text), Convert.ToDouble(txtMiktarArmut.Text), Convert.ToDouble(txtMiktarMuz.Text), Convert.ToDouble(txtMiktarKiraz.Text), Convert.ToDouble(txtMiktarPortakal.Text));
            (double fiyatElma, double fiyatArmut, double fiyatMuz, double fiyatKiraz, double fiyatPortakal) fiyatlar = (Convert.ToDouble(cboFiyatElma.Text), Convert.ToDouble(cboFiyatArmut.Text), Convert.ToDouble(cboFiyatMuz.Text), Convert.ToDouble(cboFiyatKiraz.Text), Convert.ToDouble(cboFiyatPortakal.Text));
            MessageBox.Show(fiyatlar.fiyatElma.ToString());
            kdv = Convert.ToInt32(cboKdv.Text);
            iskonto= Convert.ToInt32(cboIskonto.Text);
            toplamTutar = (adetler.adetElma * fiyatlar.fiyatElma) + (adetler.adetArmut * fiyatlar.fiyatArmut) + (adetler.adetMuz * fiyatlar.fiyatMuz) + (adetler.adetKiraz * fiyatlar.fiyatKiraz)+(adetler.adetPortakal * fiyatlar.fiyatPortakal);
            netTutar = toplamTutar + ((toplamTutar * kdv) / 100) + ((toplamTutar * iskonto) / 100);
            lblHesaplamalarToplamTutar.Text = toplamTutar.ToString();
            lblToplamTutar.Text = toplamTutar.ToString();
            lblNetTutar.Text = netTutar.ToString();
            lblKdv.Text = cboKdv.Text;
            lblIskonto.Text = cboIskonto.Text;
        }
    }
}
