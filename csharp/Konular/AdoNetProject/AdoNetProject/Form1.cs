using System.Data;
using System.Data.SqlClient;

namespace AdoNetProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        
        /*
         
         Ado.Net 
        * Activex data object veri kaynaklarýna(Oracle,mssql,mysql vs.. structured) yapýlarýna eriþmemizi ve dml iþlemleri yapmamýzý saðlayan framework(kütüphane) dir.
        * System.data ve System.Dta.SqlClient bizim  kullanacaðýmýz namespacelerdir.
        * Nuget yüklemesi gerekebilir.
        * Odbc ile de (sunucu üzerinden) baðlantý idap aracýlýðýyla yapýlýr.
        * odbc: open database connectivity yani açýk veri tabaný baðlantý saðlayacý.
         
         */
        
        
        }

        public void ComboboxKategorilerDoldur()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = Connection.conM();
            SqlDataAdapter da = new SqlDataAdapter(@$"select CategoryName from Categories", sqlConnection);
            // SqlDataAdapter disconnection bir yapýdýr. sorgu iþlemleri ile veri çekmemizi saðlar.
            // sorguyu görmek isteersen. Adapter a breakpoint at ve da nýn üstüne gel select command=>command text ile ulaþ.
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(dr.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ilk baðlantý
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = Connection.conM(); // veri tabanýna baðlantý cümlesi
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                    MessageBox.Show("Veri tabaný baðlantý iþlemi baþarýlý bir þekilde gerçekleþti.");
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString()+"\nBaðlantý sýrasýnda hata oluþtu.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection2 = new SqlConnection();
            sqlConnection2.ConnectionString = Connection.conM();
            SqlDataAdapter da = new SqlDataAdapter(@"select  E.EmployeeID AS EmployeeID,FirstName+' '+LastName as [ad Soyad], COUNT(*) as [Toplam Satýþ]                                   from Employees e inner join Orders ord 
                                                on ord.EmployeeID = e.EmployeeID
                                                group by e.EmployeeID, FirstName + ' ' + LastName", sqlConnection2);
            // SqlDataAdapter disconnection bir yapýdýr. sorgu iþlemleri ile veri çekmemizi saðlar.
            // sorguyu görmek isteersen. Adapter a breakpoint at ve da nýn üstüne gel select command=>command text ile ulaþ.
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = dt;

            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection2 = new SqlConnection();
            sqlConnection2.ConnectionString = Connection.conM();
            SqlDataAdapter da = new SqlDataAdapter(@$"select p.ProductName,p.UnitPrice,p.UnitsInStock from Products p where CategoryID = (select CategoryID from Categories c where CategoryName = '{comboBox1.Text}')", sqlConnection2);
            // SqlDataAdapter disconnection bir yapýdýr. sorgu iþlemleri ile veri çekmemizi saðlar.
            // sorguyu görmek isteersen. Adapter a breakpoint at ve da nýn üstüne gel select command=>command text ile ulaþ.
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = dt;
        }
    }
}