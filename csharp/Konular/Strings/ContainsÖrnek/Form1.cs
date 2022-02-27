namespace ContainsÖrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();



            /*
             startswith:
             
             
             */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string metin, aranan;
            metin = textBox1.Text;
            aranan = textBox2.Text;
            string gecici;
            int sayac = 0;
            int varmi =0;
            int varmi2=0;
            
                for (; varmi < metin.Length; varmi++)
                            {
                                    varmi2 = metin.IndexOf(aranan,varmi);
                                    
                    if ((varmi != -1 && varmi<varmi2) || (varmi != -1 && varmi == varmi2))
                                {
                                    varmi = varmi2 + aranan.Length;
                                    sayac++;
                                }
                                else
                                {
                                     break;
                                }

                }

            

            MessageBox.Show("Aranan ifade metin içindenin sayısı: " + sayac);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}