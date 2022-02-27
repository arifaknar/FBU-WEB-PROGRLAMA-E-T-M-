using System.Collections;

namespace Diziler2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] adlar ={ "arif", "emir" };
            string[] adlar2 = { "arif", "emir","efe" };
            Array array = new[] {adlar,adlar2 };

            
            foreach (Array str in array)
            {
                Array.Clear(str, 0, str.Length);
            }
        }

        int[,] sayilar=new int[3,3];
        int x=0, v = 0;
        int count = 0;

        private void btnIslemYap_Click(object sender, EventArgs e)
        {
            if (count > 9)
            {
                foreach (int i in sayilar)
                            {
                                MessageBox.Show(i.ToString());

                            }
            }
            else
            {
                MessageBox.Show("9 ADET SAYI GÝRÝNÝZ");
            }
           
        }

        

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
                            {   
            
                
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (x < 3)
                    {
                        if (v < 3)
                        {
                            sayilar[x,v]= int.Parse(textBox1.Text); 
                            count++;
                            textBox1.Text = "";
                        }
                        else
                        {
                            x++;
                        }
                        v++;
                    }
                            
                      
                    
                }
                catch (Exception)
                {

                    MessageBox.Show("Lütfen sayý giriniz.");
                    textBox1.Text = "";
                    
                }
                

            }
        }

        
    }
}