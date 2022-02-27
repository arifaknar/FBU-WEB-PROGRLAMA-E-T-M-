namespace Metod5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayi = 0, sonuc = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
                sayi = int.Parse(button10.Text);
           
        }

        private void button11_Click(object sender, EventArgs e)
        {
            
                sayi = int.Parse(button11.Text);
                
            
            
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (sayi!=-1)
            {
                sonuc = sonuc + sayi;
                sayi = -1;
            }
                
                MessageBox.Show(sonuc.ToString());
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (sayi != -1)
            {
                sonuc = sonuc / sayi;
                sayi = -1;
            }
            MessageBox.Show(sonuc.ToString());
        }

        public void islem()
        {

        }
    }
}