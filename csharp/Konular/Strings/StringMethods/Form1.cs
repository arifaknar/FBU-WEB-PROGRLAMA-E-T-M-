namespace StringMethods
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
             String Method

            Contains: Bir ifadeyi kontrol ederken i�erisindeki de�erin var olup olmad���n� denetler. Char olarak arama yapar. �fade i�inde herhangi bir de�er varsa yine true d�ner.
            *B�y�k k���k harf duyarl�d�r.
            Kullan�m�: metin.Contains(arananDeger)
             
             
             
            
             startswith:metinsel ifadenin i�erisinde ba�lang�� de�erinin var olup olmad���n� kontrol eder.
                    Buradaki ifade b�y�k k���k harf duyarl�d�r. E�er bu ortadan kald�r�lmak isteniyorsa StringComparison.OrdinalIgnoreCase parametresi g�nderilebilir.
            endswith: Yukar�dakilerin ayn�s�. sonu i�in.


            equals: �ki string ifadenin birbirine e�it olup olmad���na bakar. Geriye bool d�nd�r�r. kullan�m�: metin.Equals(karsilastirilanmetin);

            metin.split(ay�rmakistedi�in,nereye kadar(s�n�r)) => Split geriye verilen ay�ra�� kullanarak metni o �ekilde ay�r�r veri diziye eleman olarak atar.
            ay�rmak istedi�n k�sma char[] array atabilirsin.
             
             
             
            */


            /*
            
            Diagolog Result

            
             */

            string metin = "abcdfdd";
            MessageBox.Show(metin.StartsWith('a').ToString());
            MessageBox.Show(metin.EndsWith('d').ToString());
            DialogResult cikis = new DialogResult();
            cikis = MessageBox.Show("��k�� yapmak istiyormusunuz ?", "Uyar�", MessageBoxButtons.YesNo);
            if (cikis == DialogResult.Yes)
            {
                MessageBox.Show("Program ba�ar�yla kapat�ld�.");
                Application.Exit();
            }
            if (cikis == DialogResult.No)
            {
                MessageBox.Show("Program kapat�lmad�.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string metin, arananDeger;
            metin = textBox1.Text;
            arananDeger = textBox2.Text;

            bool varmi = metin.Contains(arananDeger, StringComparison.OrdinalIgnoreCase); 
            // StringComparison.OrdinalIgnoreCase: B�y�k  k���k harf duyarl�l��� olmadan arama yapar.

            if (varmi)
            {
                MessageBox.Show("var");
            }
            else
            {
                MessageBox.Show("yok");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string metin2 = "a.s_d,4";
            char[] ayiraclar = { '.', '_', ',' };
            string[] metin = metin2.Split(ayiraclar);
            foreach (string met in metin)
            {
                MessageBox.Show(met);
            }
        }
    }
}