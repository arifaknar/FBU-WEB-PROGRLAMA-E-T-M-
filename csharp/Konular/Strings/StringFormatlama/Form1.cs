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
             * Metinsel ifadeleri tuttu�umuz referans tipli tek t�rd�r.
             * Null: Bellekte kar��l��� olmayan daha do�rusu referans kar��l��� olmayan , alan� olmayan demektir.
             * Empty: Bellekte stack de kendisinin olup de�erinin stackte olmad��� t�rd�r. c# da default de�erlerin hepsi empty olarak ge�er.
             * 
             
             */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kelime = ""; //veya
            kelime = string.Empty;
            kelime=default;
            if (!string.IsNullOrEmpty(kelime))// IsNullOrEmpty() => bu method gelen verinin bo� olup olmad���n� kontrol eder.
            {
                MessageBox.Show(kelime);
            }
            else
            {
                MessageBox.Show("De�er bo�.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string kelime = ""; //veya
            kelime = string.Empty;
            kelime = default;
            if (!string.IsNullOrWhiteSpace(kelime) )//IsNullOrWhiteSpace() => bu method gelen verinin i�inde bo�luklar olup olmad���n� kontrol eder.
            {
                MessageBox.Show(kelime);
            }
            else
            {
                MessageBox.Show("De�erde bo�luklar var.");
            }

            if (kelime is null)
            {
                MessageBox.Show("De�er bo�.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string kelime = "FENERBAH�E �N�VERS�TES�";
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
                    MessageBox.Show("Bo� De�er");
                }
                else
                {
                    MessageBox.Show(charDizi[j].ToString());
                }
                j++;

            } while (j<charDizi.Length);

            Console.WriteLine(string.Format($"{charDizi[0]} {charDizi[0]}", Environment.NewLine)); // Environment.NewLine VER�LER ARASINDA ALT ALTA YAN� SATIR ATLAMASI YAPAR.(/N G�B�)
        }

        private void button4_Click(object sender, EventArgs e)
        { 
            listBox1.Items.Add("C : " + string.Format("{0:C1}", 25.50)); // ��kt�s� 25,5 
            listBox1.Items.Add("C : " + string.Format("{0:C2}", 25.50)); // ��kt�s� 25,50
            listBox1.Items.Add("C : " + string.Format("{0:C3}", 25.50)); // ��kt�s� 25,500
            listBox1.Items.Add("C : " + string.Format("{0:C4}", 25.50)); // ��kt�s� 25,5000
            listBox1.Items.Add("D : " + string.Format("{0:D3}", 25)); // ��kt�s� 025
            listBox1.Items.Add("D : " + string.Format("{0:D5}", 25)); // ��kt�s� 00025


            listBox1.Items.Add("F : " + string.Format("{0:F1}", 25.50)); // ��kt�s� 25,5
            listBox1.Items.Add("F : " + string.Format("{0:F2}", 25.50)); // ��kt�s� 25,50
            listBox1.Items.Add("F : " + string.Format("{0:F3}", 25.50)); // ��kt�s� 25,500
            listBox1.Items.Add("N : " + string.Format("{0:N}", 2550000)); // ��kt�s� 2.550.000,00
            listBox1.Items.Add("X : " + string.Format("{0:X}", 2550)); // ��kt�s� 9f6
            listBox1.Items.Add("0 : " + string.Format("{0:00000.00}", 25.50)); // ��kt�s� 00025,50
            listBox1.Items.Add("# : " + string.Format("{0:###.##}", 25.50)); // ��kt�s� 25,5
        }

        private void button5_Click(object sender, EventArgs e)
        {

            /*
             String interpolation => "" lar aras�na kodla de�er yazmak i�in kullan�l�r. kullan�m�: $"{txtAd.Text} adl� ��renci"
             c# 6.0 ile geldi.
             */
            string ogrenciDurum = @$"{txtAd.Text} {txtSoyad.Text} isimli ��rencimizin sicil numaras� {txtSicilNo.Text} \rba�l� not incelemelerinde ald��� t�m dersler,n not ortalamas� { txtNot.Text} dir. \r Bu husus g�z�n�nde bulunduruldu�unda ilgili birim y�neticisi \r {txtYonetici.Text} ilgili rehberlik s�recinin ba�lat�lmas� uygundur.";
            label6.Text = ogrenciDurum;
            label6.Visible = true;
        }
    }
}