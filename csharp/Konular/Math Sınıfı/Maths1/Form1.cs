namespace Maths1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            notlar.Clear();


        }
        string[] ogrenciler = { "ARÝF", "ONUR", "BORA", "EMÝN", "CEMÝL", "BURAK", "AYÞENUR", "MERT", "RUKÝYE", "MELTEM", "ALPER", "FATÝH", "SÝNAN", "MUSTAFA" };
        List<double> notlar = new List<double>();
        int gecen = 0, kalan = 0;
        Random random = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            gecen = 0;
            kalan = 0;
            lblKalan.Text = kalan.ToString();
            lblGecen.Text = gecen.ToString();
            lblOrt.Text = 0.ToString();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            notlar.Clear();
            //random notlar
            for (int i = 0; i<ogrenciler.Length ; i++)
            {
                notlar.Add(random.Next(0, 100));
                listBox1.Items.Add(ogrenciler[i]);
                listBox2.Items.Add(notlar[i]);
                if (notlar[i] > 49.5)
                {
                    gecen++;
                }
                else
                {
                    kalan++;
                }
            }
                
                lblGecen.Text=gecen.ToString();
                lblKalan.Text=kalan.ToString();
                lblOrt.Text=notlar.Average().ToString();

            
        }
    }
}