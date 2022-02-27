namespace ForeachExamples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string metin = textBox1.Text;

            foreach (var item in metin)
            {
                MessageBox.Show(item.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                
                if (i is 5)
                {
                    MessageBox.Show("Döngü Bitti!");
                    break;
                }
                MessageBox.Show(i.ToString());
            }
        }
    }
}