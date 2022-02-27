namespace Donguler1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    listBox1.Items.Add(i + " * " + j + " = " + (i * j));
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int satir = 0, sutun = 0;
            try
            {
                listBox2.Items.Clear();
                satir = Convert.ToInt32(textBox1.Text);
                sutun = Convert.ToInt32(textBox2.Text);
                string sat�rIci = "   ";
                
                for (int j = 1; j <= sutun; j++)
                {
                    sat�rIci = sat�rIci + j + " ";
                }
                listBox2.Items.Add(sat�rIci);


                for (int i = 1; i <= satir; i++)
                {

                    listBox2.Items.Add(i);
                }
            }
            catch (FormatException fm)
            {

                MessageBox.Show("L�tfen ge�erli de�erler de�erler giriniz. \n"+fm.ToString() );
            }
            catch(DivideByZeroException de)
            {
                MessageBox.Show("L�tfen s�f�rdan farkl� de�erler giriniz.\n" + de.ToString());
            }

            for (int i = 1,j=2;(i<5 || j < 9); i++,j++) //tam i� i�e d�ng� de�il(yar�m kalm�� ((: )
            {
                MessageBox.Show(i.ToString()+" "+j.ToString());
            }
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    /*
     D�ng�ler
    * Ba�lang�� ya da biti� de�eri vermeye gerek yoktur gerekli algoritma ile bunu biz sa�layabiliriz.
    * D�ng�ye girdi de�erini d��ar�da verebiliriz.
     
     
     
     */
}