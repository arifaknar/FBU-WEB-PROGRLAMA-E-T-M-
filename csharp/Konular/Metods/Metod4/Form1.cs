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
             Geriye Deðer Döndüren Metod
                // eriþim belirleyici verilir, tip verilir isim verilir.
             
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

        public List<int> Liste() //List<int> türünde deðer döndüren metod
        {
            List<int> notlar = new List<int>() {5,23,54,67,21,45};

            return notlar;
        }

        public int ToplaNot(List<int> liste) // List<int> türünde parametre alan ve int tipinde deðer döndüren metod.
        {
            int toplam = 0;

            toplam=liste.Sum();
            return toplam;
        }
    }
}