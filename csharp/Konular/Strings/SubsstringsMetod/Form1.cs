namespace SubsstringsMetod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
         
         Substring= Belirli metin içinde belirli aralýktan baþlamak üzere istenilen karater sayýsý kadar metni alýr.

           kullanýmý: metin.Substring(baslangýc, istenilenKarakterSayýsý)
         
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
                MessageBox.Show("Lütfen geçerli deðerler giriniz.");
            }
            
        }
    }
}