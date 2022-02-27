using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AkısKontrolMekanizmalari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
             Switch Case
            1. Sadece eşitlik durumda çalışır.(Patern larda farklılık gösterebilir.)
            2. Durum ve değişken kontrollerinde çok kullanılır.
            3. Karşılaştırma operatörleri kullanılmaz.(<,>..)
            4. Kodun akışında case sağlandığında yönlendirmemize olanak sağlar.
            5. Case lerin her biri farklı değer olmalıdır.
            6. Case içindeki değerin değişken tipi switch de belirtilen değişken türü ile örtüşmelidir.
             */

            /* Switch Case When Özelliği 
             
             kullanımı: case caseValue when(degisken(<,>..kosul operatörü)value:kodlar break; )
            case 50 when(devamsizlik>10):
            .........kodlar
            break;
             */

            // Switch Expression Özelliği c# 8.0 ile gelen patern 
             
             
            int islem = comboBox1.SelectedIndex;
            string islemAdi = islem switch
            {
                0 => "Toplama",
                1 => "Çıkarma",
                _ => "Bilinmiyor"
            };
            MessageBox.Show(islemAdi);
            
            
            
        }

        private void btnIslemYap_Click(object sender, EventArgs e)
        {

            int index = comboBox1.SelectedIndex;
            int sayi1 = Convert.ToInt32(txtSayi1.Text),sayi2= Convert.ToInt32(txtSayi2.Text);
            switch (index)
            {
                case 0:
                    MessageBox.Show((sayi1 + sayi2).ToString());
                    break;
                case 1:
                    if (sayi1 >= sayi2)
                    {
                        MessageBox.Show((sayi1 - sayi2).ToString());
                    }
                    else
                    {
                        MessageBox.Show("Geçersiz İşlem. Sayı 1 Sayı 2 den küçük olamaz.");
                    }

                    break;
                case 2:
                    if (sayi2!=0)
                    {
                        MessageBox.Show((sayi1 / sayi2).ToString());
                    }
                    else
                    {
                        MessageBox.Show("Geçersiz İşlem. O a bölme hatası.");
                    }
                    break;
                case 3:
                    MessageBox.Show((sayi1 * sayi2).ToString());
                    break;
                case 4:
                    if (sayi1 >=0 && sayi2 >= 0)
                    {
                        MessageBox.Show((sayi1 % sayi2).ToString());
                    }
                    else
                    {
                        MessageBox.Show("Geçersiz İşlem. Sayı 1 Sayı 2 den küçük olamaz.");
                    }
                    break;
                default:
                    goto case 0;

            }
        }
    }
}
