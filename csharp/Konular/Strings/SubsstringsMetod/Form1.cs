namespace SubsstringsMetod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
         
         Substring= Belirli metin i�inde belirli aral�ktan ba�lamak �zere istenilen karater say�s� kadar metni al�r.

           kullan�m�: metin.Substring(baslang�c, istenilenKarakterSay�s�)
         
         */


        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                            string metin = textBox1.Text;
                            int baslangic, bitis;
                            baslangic = int.Parse(textBox2.Text);
                            bitis=int.Parse(textBox3.Text);
                            metin = metin.Substring(baslangic,bitis);
                             MessageBox.Show(metin);
            }
            catch (Exception)
            {
                MessageBox.Show("L�tfen ge�erli de�erler giriniz.");
            }
            
        }
    }
}