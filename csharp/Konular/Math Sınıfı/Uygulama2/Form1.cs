namespace Uygulama2
{
    public partial class Form1 : Form
    {
        Random  rnd=new Random();
        int sicilNo;

        public Form1()
        {
            InitializeComponent();
            sicilNo=rnd.Next(0, 15);
            txtSicilNo.Text = sicilNo.ToString();
        }
            Dictionary<string,string> sicilNoAdSoyad = new Dictionary<string,string>();
            List<string> departman = new List<string>{"Muhasebe", "Bilgi Ýþlem", "Ýnsan Kaynaklarý", "Üretim" };
            List<int> maas = new List<int>();
        private void button1_Click(object sender, EventArgs e)
        {
            if (sicilNoAdSoyad.Count < 15)
            {
                if (txtAdSoyad.Text != "")
                {
                    listBox1.Items.Add(sicilNo.ToString() + " " + txtAdSoyad.Text);
                    listBox2.Items.Add(txtDepartman.Text);
                    listBox3.Items.Add(txtMaas.Text);
                    if (sicilNoAdSoyad.ContainsKey(sicilNo.ToString()) == true && sicilNoAdSoyad.Count>1)
                    {
                        while (sicilNoAdSoyad.ContainsKey(sicilNo.ToString()) == false)
                        {
                            sicilNo = rnd.Next(1, 15);
                            txtSicilNo.Text = sicilNo.ToString();
                        }

                        sicilNoAdSoyad.Add(sicilNo.ToString(), txtAdSoyad.Text);

                    }
                    else
                    {
                        sicilNoAdSoyad.Add(sicilNo.ToString(), txtAdSoyad.Text);
                    }
                    
                    departman.Add(txtDepartman.Text);
                    maas.Add(int.Parse(txtMaas.Text));
                }
                txtMaas.Text = "";
                txtDepartman.Text = "";
                txtSicilNo.Text = "";
                txtAdSoyad.Text = "";

                sicilNo = rnd.Next(0, 15);

                if (sicilNoAdSoyad.ContainsKey(sicilNo.ToString()) == true)
                {
                    while (sicilNoAdSoyad.ContainsKey(sicilNo.ToString()) == false)
                    {
                        sicilNo = rnd.Next(1, 15);
                        txtSicilNo.Text = sicilNo.ToString();
                    }
                    


                }
                else
                {
                    txtSicilNo.Text = sicilNo.ToString();

                }
            }
            else
            {
                MessageBox.Show("Personel Sýnýrýna Ulaþýldý!!");
            }


            



            
        }

        private void txtAdSoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAdSoyad_Leave(object sender, EventArgs e)
        {
            if (txtAdSoyad.Text.Trim() != "" && txtDepartman.Text.Trim()=="")
            {
                int departmanNo=rnd.Next(0,departman.Count);
                txtDepartman.Text = departman[departmanNo];
                txtMaas.Text = rnd.Next(1000, 10000).ToString();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtDepartman.ReadOnly = true;
            txtMaas.ReadOnly = true;
            txtSicilNo.ReadOnly = true;
        }
    }
}