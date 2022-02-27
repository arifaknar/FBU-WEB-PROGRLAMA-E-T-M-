using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AkısKontrolMekanizmlari2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region if else
            /*
             1. Karşılaştırmalı operatörlerin hepsi if içinde kullanılır.
             2. Switch Case den farkı switch tek bir değer üzerinden kontrol sağlarken if içerisine defalarca koşul yazılabilir.
             
             */
            int sayi = 1;
            //iki ürünün fiyatı girildiğinde toplam fiyat eğer ki 200 tl > ise 2. üründen %20 indirim yapsın. fiyatı hesaplasın 
            //switch ve if ile hesaplama işlemleri
            //turnery ve if yapısı ile login firiş ekranı

            #endregion

            double fiyat1, fiyat2, toplamFiyat;

            fiyat1 = Convert.ToDouble(txtFiyat1.Text);
            fiyat2 = Convert.ToDouble(txtFiyat2.Text);
            toplamFiyat = fiyat1 + fiyat2;

            if (toplamFiyat > 200) fiyat2 = fiyat2 - ((fiyat2 * 20) / 100);

            toplamFiyat = fiyat1 + fiyat2;
            MessageBox.Show("Toplam: " + toplamFiyat);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string kullaniciAdi, password;
            kullaniciAdi = txtKullaniciAdi.Text.ToLower().Trim();
            password=txtSifre.Text.ToLower().Trim();

            string sonuc=kullaniciAdi == "admin" && password == "1234" ? "Giriş Başarılı" : "Giriş Başarısız. Kullanıcı adı veya sifre hatalı.";
            MessageBox.Show(sonuc);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, sonuc=0;
            string islem = cboİslem.Text;

            sayi1 = Convert.ToDouble(txtSayi1.Text);
            sayi2 = Convert.ToDouble(txtSayi2.Text);

            switch (islem)
            {
                case "/":
                    if(sayi1!=0 && sayi2 == 0)
                    {
                        MessageBox.Show("Sıfıra bölmr hatası");
                        break;
                    }
                    sonuc = sayi1 / sayi2;
                    MessageBox.Show($"Sonuç: {sonuc} ");
                    break;
                case "*":
                    sonuc = sayi1 * sayi2;
                    MessageBox.Show($"Sonuç: {sonuc} ");
                    break;
                case "+":
                    sonuc = sayi1 + sayi2;
                    MessageBox.Show($"Sonuç: {sonuc} ");
                    break;
                case "-":
                    sonuc = sayi1 - sayi2;
                    MessageBox.Show($"Sonuç: {sonuc} ");
                    break;
                default:
                    MessageBox.Show("Bir işlem seçiniz");
                    break;
            }

            
        }
    }
}
