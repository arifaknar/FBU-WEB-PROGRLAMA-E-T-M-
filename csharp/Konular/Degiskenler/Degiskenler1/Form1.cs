using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Degiskenler1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region Degiskenler
            
            #endregion

            /*
            
            1. En kritik konudur. Bellek nesnesidir.
            
            2. İhtiyaç duyma nedenimiz veriyi doğru bir şekilde işleyebilmemiz için  
            programla dilinde verileri ramde tutmak zorundayız.
            
            3. Yazılımdaki temel amaç veriyi doğru işlemek ve işletebilmektedir.
            
            4. Bu noktada karşımıza değişkenler çıkmaktadır. Örneğin bir yaş değerini
            ya da fatura numarası değerini yazılım dilinde karşılayabilmek için
            ilk önce ramde buna karşılık yer ayırır ve sonra ilgili degisken türünde 
            bilinçli bir şekilde oluşturarak atarız.
            
            5. C# da bir değişkene değer atamak zorunludur.

            6. Garbage collection ile ram yazılım dilinde oluşturduğumuz değişkenlerin
            atamalarını otomatikman yapar. Örneğin siz bir değişken oluşturduğunuzda bunu 
            kullanmazsanız garbage bunu siler.
            
            7. Primitive, Value ve Referans tipler mevcuttur.

            8. Primitive tip: byte x=0;
            
            9. Value Tip: int x1=123;

            10. Referans Tip: string isim="yunus"

            11. Değişken tanımlama: Degisken Tipi degiskenadi=referans değeri

            12. Değişkenler kendi aralarında mantıksal,metinsel,sayısal ve ondalıklı olacak şekilde
            kategorilere ayrılırlar.

            13. Tüm türler ramde 5 yerde saklanırlar. En önemlileri stack ve hesap tir.
            Diğerleri register,const ve static.

            14. Ramin çalışma prensibi ilk giren ilk çıkar.

            15. Önemli :
            * Değişkenler anlamlı isimlendirilmelidir.
            * İsimlendirmede özel karakter kullanılmaz.
            * İsimlendirme sayısal ifade ile başlamaz.
            * Aynı scope içinde birden fazla aynı adda değişken olmaz.
            * Keyword isimlendirmede kullanılmaz(int,if gibi.) Bazı istisnalar vardır. örn: string @static ="arif" 
            * ( @ işareti kullanabilir.) ancak önerilmez.
            * Bir değişkene atılan en son değer geçerlidir.
            * 
            
            
             */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt16(textBox1.Text);
            int sayi2 = Convert.ToInt16(textBox2.Text);
            MessageBox.Show((sayi1 + sayi2).ToString());
        }

        private void btnPersonelAdd_Click(object sender, EventArgs e)
        {
            string adSoyad = txtAdSoyad.Text;
            string tcKimlikNo = txtTcKimlikNo.Text;
            decimal maas =Convert.ToDecimal(txtMaas.Text);
            string cinsiyet = cboCinsiyet.Text;

            lbxPersonelDetay.Items.Add(adSoyad);
            lbxPersonelDetay.Items.Add(tcKimlikNo);
            lbxPersonelDetay.Items.Add(maas);
            lbxPersonelDetay.Items.Add(cinsiyet);

        }
    }
}
