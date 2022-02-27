using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Degiskenler2
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
             Tuple= C# 7.0 ile gelmiştir.
            Tek bir sytax üzerinden birden fazla değişkeni gruplayarak kullanmanızı sağlar.
             
            Literal kullanımı.:Değişken kullanırken sayıların arasına_ koyulabilmesidir.
            int lsayi1=323_34_546

            Default değer atama: int y=default;

            Checked { kodlar.........} : Eğer dönüşümde bir veri kaybı, veri taşması, 
            verinin aldığı değeri manipüle eden bir durum varsa checked arkadaş bunu kontrol eder. Hata verir.
            unchecked{kodlar......} : Checked in tam tersi. Hata vermez.
            
             
             */

            /*
             Const değişken türü =değer;
                Const ile oluşturulan değere oluşturulduğu sırada bir değer verilmek zorundadır.
            Bu değeri daha sonra değiştiremeyiz. Değiştirmek istersek ilk oluşturduğumuz yere gelip değiştirebilir.
            Constlar özünde statiktir ve ramde statik olarak işaretlenir.


             */

            /*
             Araştırma Konusu: Deep copy ve shollow compy 
             */
            #region Değişmezler Const
            const decimal pi = 3.14m;

            #endregion




        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* Tuple Örneği: */
            (string isim, int yas, string tcKimlikNo) kisi = ("Arif", 25, "111111111111");
            (decimal maas, decimal prim, decimal vergi) bordro = (5000, 1000, 18);
            textBox1.Text = kisi.isim;
            textBox2.Text = kisi.tcKimlikNo;
            textBox3.Text = (kisi.yas).ToString();
            textBox4.Text = (bordro.maas + bordro
                .prim - ((bordro.maas * bordro.vergi) / 100)).ToString();
        }
    }
}
