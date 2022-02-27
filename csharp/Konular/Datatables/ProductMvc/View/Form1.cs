using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using ProductMvc.Controllers;
namespace ProductMvc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProductManager productManager=new ProductManager();
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Baglantilarim.connectionString;
            DataTable dt = new DataTable(productManager.UrunleriGetir(comboBox1.Text, conn));

            foreach (DataRow dr in )
            {
                comboBox1.Items.Add(dr.ToString());
            }
            
        }
    }
}