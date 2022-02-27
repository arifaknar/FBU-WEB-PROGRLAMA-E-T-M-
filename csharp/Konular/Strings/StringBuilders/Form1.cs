using System.Text;

namespace StringBuilders
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
             String Builder
            * Performanslý string birleþtirme yapan bir fonksiyon.
            * 
             
             
             
             */

            string isim = "yunus";
            string soyIsim = "çelik";
            StringBuilder stringBuilder = new StringBuilder();
            //buildera metin ekleme
            stringBuilder.Append(isim);
            stringBuilder.Append(" ");
            stringBuilder.Append(soyIsim);
            stringBuilder.Append(" ");
            //formatlama
            stringBuilder.AppendFormat("{0:C}", 25);

            MessageBox.Show(stringBuilder.ToString());

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            /* Span: Ram üzerinde bellekte belli bir alaný temsil eden array yapýlanmasýdýr. Performans saðlar.
             */

            int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Span<int> s1 = new Span<int>(sayilar);
            foreach (var item in s1)
            {
                MessageBox.Show(item.ToString());
            }
        }
    }
}