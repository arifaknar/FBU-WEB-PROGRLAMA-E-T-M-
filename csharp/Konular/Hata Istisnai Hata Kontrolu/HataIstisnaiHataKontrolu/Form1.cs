using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HataIstisnaiHataKontrolu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /* TRY CATCH
         * try catch yazmak maaliyetlidir.
         * Çalışma zamanını karşılayan hata kontrol mekanizmalarıdır.
         * Ortaya çıkabilecek hataların etkilerini düşürere ve manipüle etmek için kullanılır.
         * loglama yapısında çok sık kullanılır.
         * En önemlisi hata durumunda kullanıcı bilgilendirilir ve bu durumun kullanıcıya hissetdirilmemesi amaçlanır.
         * Birden fazla catch eklenebilir.
         * Mülakat sorusu: Hata için uygun catch açılmazsa hata verir.ya da koşulsuz exception catch tanımla.
         * Alınan Hata Türleri
            Derleyici Hataları: sytax hataları, yada derleme sonrasında ortaya çıkan hatalardır. Satır olarak hatayı error list gösterir, çözümü en kolay olmalıdırç
        
            Mantıksal Hatalar: Fatura tutarı hesaplama hatası, bordro kesinti hatası,, iki sayıyı topladığında çıkan sonucun hatalı olması vs.

            Run Time Hataları: sytax da problem yok, kod doğru kurallarla yazılmış fakar çalışma anında alınan hata mesajlarıdır. Son kullanıcı direkt bu hataya maruz kalır.
            Run time error ya da jit error. Testerlar bu hataları bulmak ve bildirmekle yükümlüdür. Bu hatalar loglanmalıdır.

            örnek: veri tabanı bağlantı hatası, olmayan bir nesne ya da değer, ya da uygun olmayan format gibi.
            
         
         
         */

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string x = "as4";
            int sayi=5;

            try
            {
                MessageBox.Show((Convert.ToInt16(x) + sayi).ToString());
            }
            catch (FormatException fe)
            {
                MessageBox.Show("İt ekibine hata bildirldi." + fe.ToString());
               //loglama ,email gönderimi vs yapılabilir.
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string errorDesc = "";
            int islem = 0;

            try
            {
                switch (comboBox1.Text)
                {
                    case "+":
                        errorDesc = "Toplama Hatası";
                        islem = int.Parse(txtSayi1.Text) + int.Parse(textBox2.Text);
                        MessageBox.Show(islem.ToString());
                        break;
                    case "-":
                        errorDesc = "Çıkarma Hatası";
                        islem = int.Parse(txtSayi1.Text) - int.Parse(textBox2.Text);
                        MessageBox.Show(islem.ToString());
                        break;
                    case "/":
                        errorDesc = "Bölme Hatası";
                        if(txtSayi1.Text!="0" && textBox2.Text == "0")
                        {
                            islem = int.Parse(txtSayi1.Text) / int.Parse(textBox2.Text);
                            MessageBox.Show(islem.ToString());
                        }
                        
                        break;
                    case "*":
                        errorDesc = "Çarpma Hatası";
                        islem = int.Parse(txtSayi1.Text) * int.Parse(textBox2.Text);
                        MessageBox.Show(islem.ToString());
                        break;
                    default:
                        break;
                }
            }
            catch(DivideByZeroException de) when(txtSayi1.Text=="hata")
            {
                MessageBox.Show(errorDesc + " " + de.ToString());
                //throw;
            }
            catch (FormatException fe)
            {
                MessageBox.Show(errorDesc + " " + fe.ToString());
            }

            catch (Exception ex)
            {

                MessageBox.Show(errorDesc + " " + ex.ToString());
            }
            finally
            {
                MessageBox.Show("Her şeye rağmen çalıştım.");
            }
           // kimbil etl developer araştır
        }
    }
}
