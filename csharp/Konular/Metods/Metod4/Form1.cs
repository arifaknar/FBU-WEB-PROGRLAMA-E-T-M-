namespace Metod4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
             Geriye De�er D�nd�ren Metod
                // eri�im belirleyici verilir, tip verilir isim verilir.
             
             */

            string ad = AdAl();
            MessageBox.Show(ad);
        }

        string AdAl()
        {
            return "arif";
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            List<int> notKopyasi = Liste();
            int toplamNot = ToplaNot(notKopyasi);
            MessageBox.Show(toplamNot.ToString());


        }

        public List<int> Liste() //List<int> t�r�nde de�er d�nd�ren metod
        {
            List<int> notlar = new List<int>() {5,23,54,67,21,45};

            return notlar;
        }

        public int ToplaNot(List<int> liste) // List<int> t�r�nde parametre alan ve int tipinde de�er d�nd�ren metod.
        {
            int toplam = 0;

            toplam=liste.Sum();
            return toplam;
        }
    }
}