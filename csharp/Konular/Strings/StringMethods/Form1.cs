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

            Contains: Bir ifadeyi kontrol ederken içerisindeki deðerin var olup olmadýðýný denetler. Char olarak arama yapar. Ýfade içinde herhangi bir deðer varsa yine true döner.
            *Büyük küçük harf duyarlýdýr.
            Kullanýmý: metin.Contains(arananDeger)
             
             
             
            
             startswith:metinsel ifadenin içerisinde baþlangýç deðerinin var olup olmadýðýný kontrol eder.
                    Buradaki ifade büyük küçük harf duyarlýdýr. Eðer bu ortadan kaldýrýlmak isteniyorsa StringComparison.OrdinalIgnoreCase parametresi gönderilebilir.
            endswith: Yukarýdakilerin aynýsý. sonu için.


            equals: Ýki string ifadenin birbirine eþit olup olmadýðýna bakar. Geriye bool döndürür. kullanýmý: metin.Equals(karsilastirilanmetin);

            metin.split(ayýrmakistediðin,nereye kadar(sýnýr)) => Split geriye verilen ayýraçý kullanarak metni o þekilde ayýrýr veri diziye eleman olarak atar.
            ayýrmak istediðn kýsma char[] array atabilirsin.
             
             
             
            */


            /*
            
            Diagolog Result

            
             */

            string metin = "abcdfdd";
            MessageBox.Show(metin.StartsWith('a').ToString());
            MessageBox.Show(metin.EndsWith('d').ToString());
            DialogResult cikis = new DialogResult();
            cikis = MessageBox.Show("Çýkýþ yapmak istiyormusunuz ?", "Uyarý", MessageBoxButtons.YesNo);
            if (cikis == DialogResult.Yes)
            {
                MessageBox.Show("Program baþarýyla kapatýldý.");
                Application.Exit();
            }
            if (cikis == DialogResult.No)
            {
                MessageBox.Show("Program kapatýlmadý.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string metin, arananDeger;
            metin = textBox1.Text;
            arananDeger = textBox2.Text;

            bool varmi = metin.Contains(arananDeger, StringComparison.OrdinalIgnoreCase); 
            // StringComparison.OrdinalIgnoreCase: Büyük  küçük harf duyarlýlýðý olmadan arama yapar.

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