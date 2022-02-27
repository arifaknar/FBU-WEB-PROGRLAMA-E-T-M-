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
             Regular Expression : D�zenli Yap�lar
            *D�zenli yap�larda �artlanmalar� ve belirli ko�ullar�n sa�lanmas�n� , kontrollerini sa�layan yap�lar.
            *using System.Text.RegularExpression �singini kullan�r.
            *regex=> Bir string ifadenin belli kurallara olan uyumlulu�unu denetler.
             
             */

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string metin = textBox1.Text;

            Regex regex = new Regex("^A");
            Match match = regex.Match(metin);
            if (match.Success)
            {
                MessageBox.Show("A HARF� �LE BA�LIYOR.");
            }
            else
            {
                MessageBox.Show("A HARF� �LE BA�LAMIYOR.");
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
            //match metodu i�erisine de�er,de�erin format�, format�nda case kontrol� eklenebilir.
            Match eslesme=Regex.Match(metin,RegexDesen,RegexOptions.IgnoreCase);

            if (eslesme.Success)
            {
                MessageBox.Show("Telefon format� do�ru.");
                return;
            }
            else
            {
                MessageBox.Show("Telefon format� do�ru de�il.");
            }
        }
    }
}