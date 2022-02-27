namespace StringFormatlama
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
             String
             * Metinsel ifadeleri tuttuðumuz referans tipli tek türdür.
             * Null: Bellekte karþýlýðý olmayan daha doðrusu referans karþýlýðý olmayan , alaný olmayan demektir.
             * Empty: Bellekte stack de kendisinin olup deðerinin stackte olmadýðý türdür. c# da default deðerlerin hepsi empty olarak geçer.
             * 
             
             */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kelime = ""; //veya
            kelime = string.Empty;
            kelime=default;
            if (!string.IsNullOrEmpty(kelime))// IsNullOrEmpty() => bu method gelen verinin boþ olup olmadýðýný kontrol eder.
            {
                MessageBox.Show(kelime);
            }
            else
            {
                MessageBox.Show("Deðer boþ.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string kelime = ""; //veya
            kelime = string.Empty;
            kelime = default;
            if (!string.IsNullOrWhiteSpace(kelime) )//IsNullOrWhiteSpace() => bu method gelen verinin içinde boþluklar olup olmadýðýný kontrol eder.
            {
                MessageBox.Show(kelime);
            }
            else
            {
                MessageBox.Show("Deðerde boþluklar var.");
            }

            if (kelime is null)
            {
                MessageBox.Show("Deðer boþ.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string kelime = "FENERBAHÇE ÜNÝVERSÝTESÝ";
            char[] charDizi = new char[kelime.Length];

            for (int i = 0; i < charDizi.Length; i++)
            {
                charDizi[i] = kelime[i];
            }
            int j = 0;
            do
            {
                if ( charDizi[j].ToString()==string.Empty )
                {
                    MessageBox.Show("Boþ Deðer");
                }
                else
                {
                    MessageBox.Show(charDizi[j].ToString());
                }
                j++;

            } while (j<charDizi.Length);

            Console.WriteLine(string.Format($"{charDizi[0]} {charDizi[0]}", Environment.NewLine)); // Environment.NewLine VERÝLER ARASINDA ALT ALTA YANÝ SATIR ATLAMASI YAPAR.(/N GÝBÝ)
        }

        private void button4_Click(object sender, EventArgs e)
        { 
            listBox1.Items.Add("C : " + string.Format("{0:C1}", 25.50)); // Çýktýsý 25,5 
            listBox1.Items.Add("C : " + string.Format("{0:C2}", 25.50)); // Çýktýsý 25,50
            listBox1.Items.Add("C : " + string.Format("{0:C3}", 25.50)); // Çýktýsý 25,500
            listBox1.Items.Add("C : " + string.Format("{0:C4}", 25.50)); // Çýktýsý 25,5000
            listBox1.Items.Add("D : " + string.Format("{0:D3}", 25)); // Çýktýsý 025
            listBox1.Items.Add("D : " + string.Format("{0:D5}", 25)); // Çýktýsý 00025


            listBox1.Items.Add("F : " + string.Format("{0:F1}", 25.50)); // Çýktýsý 25,5
            listBox1.Items.Add("F : " + string.Format("{0:F2}", 25.50)); // Çýktýsý 25,50
            listBox1.Items.Add("F : " + string.Format("{0:F3}", 25.50)); // Çýktýsý 25,500
            listBox1.Items.Add("N : " + string.Format("{0:N}", 2550000)); // Çýktýsý 2.550.000,00
            listBox1.Items.Add("X : " + string.Format("{0:X}", 2550)); // Çýktýsý 9f6
            listBox1.Items.Add("0 : " + string.Format("{0:00000.00}", 25.50)); // Çýktýsý 00025,50
            listBox1.Items.Add("# : " + string.Format("{0:###.##}", 25.50)); // Çýktýsý 25,5
        }

        private void button5_Click(object sender, EventArgs e)
        {

            /*
             String interpolation => "" lar arasýna kodla deðer yazmak için kullanýlýr. kullanýmý: $"{txtAd.Text} adlý öðrenci"
             c# 6.0 ile geldi.
             */
            string ogrenciDurum = @$"{txtAd.Text} {txtSoyad.Text} isimli öðrencimizin sicil numarasý {txtSicilNo.Text} \rbaðlý not incelemelerinde aldýðý tüm dersler,n not ortalamasý { txtNot.Text} dir. \r Bu husus gözönünde bulundurulduðunda ilgili birim yöneticisi \r {txtYonetici.Text} ilgili rehberlik sürecinin baþlatýlmasý uygundur.";
            label6.Text = ogrenciDurum;
            label6.Visible = true;
        }
    }
}