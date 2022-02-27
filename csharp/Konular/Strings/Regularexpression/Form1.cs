using System.Text.RegularExpressions;

namespace Regularexpression
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
             Regular Expression : Düzenli Yapýlar
            *Düzenli yapýlarda þartlanmalarý ve belirli koþullarýn saðlanmasýný , kontrollerini saðlayan yapýlar.
            *using System.Text.RegularExpression üsingini kullanýr.
            *regex=> Bir string ifadenin belli kurallara olan uyumluluðunu denetler.
             
             */

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string metin = textBox1.Text;

            Regex regex = new Regex("^A");
            Match match = regex.Match(metin);
            if (match.Success)
            {
                MessageBox.Show("A HARFÝ ÝLE BAÞLIYOR.");
            }
            else
            {
                MessageBox.Show("A HARFÝ ÝLE BAÞLAMIYOR.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tarih = @"20/04/2020";
            string pattern = @"(-)|(/)";
            string[] result=Regex.Split(tarih, pattern);

            foreach (string s in result)
            {
                MessageBox.Show(s);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string metin = textBox1.Text;
            string RegexDesen = @"^(0(\d{3}) -(\d{3}) - (\d{2}) - (\d{2}))$"; 
            //match metodu içerisine deðer,deðerin formatý, formatýnda case kontrolü eklenebilir.
            Match eslesme=Regex.Match(metin,RegexDesen,RegexOptions.IgnoreCase);

            if (eslesme.Success)
            {
                MessageBox.Show("Telefon formatý doðru.");
                return;
            }
            else
            {
                MessageBox.Show("Telefon formatý doðru deðil.");
            }
        }
    }
}