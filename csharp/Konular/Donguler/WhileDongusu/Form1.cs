namespace WhileDongusu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
             * Klayveyeden girilen say�lar� 100 den geriye s�f�ra b�l�nen ve b�l�nmeyenleri ay�ran program.
             
             */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1,sayi2;
            try
            {
                sayi1 = int.Parse(textBox1.Text);
                sayi2 = int.Parse(textBox2.Text);
                if (sayi1 > 100 || sayi2 > 100)
                {
                    MessageBox.Show("L�tfen 0-100 aras�nda de�erler giriniz.");
                    textBox1.Clear();
                    textBox2.Clear();
                }
                for (int i = sayi1; i <= sayi2; i++)
                {

                    if (i % 2 == 0)
                    {
                        listBox1.Items.Add(i);
                    }
                    else
                    {
                        listBox2.Items.Add(i);
                    }


                }
            }
            catch (FormatException)
            {

                MessageBox.Show("L�tfen bir de�er giriniz.");
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Char harf = 'A';
            do
            {
                MessageBox.Show(harf.ToString());
                harf++;
            } while (harf<='Z');
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int sayi1 = int.Parse(textBox3.Text);
                int sayi2 = int.Parse(textBox4.Text);
                int mod = int.Parse(textBox5.Text);
                int toplam = 0;
                if (sayi1 > 1000 || sayi2 > 1000 || sayi1 > sayi2 || mod==1 || mod==0)
                {
                    MessageBox.Show("L�tfen ge�erli de�erler giriniz.");
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                }
                else
                {
                                    do
                                    {
                                        if (sayi1 % mod == 0)
                                        {
                                            toplam = toplam + sayi1;
                                        }

                                        sayi1++;
                                    } while (sayi1 <= sayi2);
                }
               
                

                textBox6.Text = toplam.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show("L�tfen ge�erli de�erler giriniz. " + ex.ToString());
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
            }
           
        }
    }
}