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
        * Activex data object veri kaynaklar�na(Oracle,mssql,mysql vs.. structured) yap�lar�na eri�memizi ve dml i�lemleri yapmam�z� sa�layan framework(k�t�phane) dir.
        * System.data ve System.Dta.SqlClient bizim  kullanaca��m�z namespacelerdir.
        * Nuget y�klemesi gerekebilir.
        * Odbc ile de (sunucu �zerinden) ba�lant� idap arac�l���yla yap�l�r.
        * odbc: open database connectivity yani a��k veri taban� ba�lant� sa�layac�.
         
         */
        
        
        }

        public void ComboboxKategorilerDoldur()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = Connection.conM();
            SqlDataAdapter da = new SqlDataAdapter(@$"select CategoryName from Categories", sqlConnection);
            // SqlDataAdapter disconnection bir yap�d�r. sorgu i�lemleri ile veri �ekmemizi sa�lar.
            // sorguyu g�rmek isteersen. Adapter a breakpoint at ve da n�n �st�ne gel select command=>command text ile ula�.
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(dr.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ilk ba�lant�
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = Connection.conM(); // veri taban�na ba�lant� c�mlesi
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                    MessageBox.Show("Veri taban� ba�lant� i�lemi ba�ar�l� bir �ekilde ger�ekle�ti.");
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString()+"\nBa�lant� s�ras�nda hata olu�tu.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection2 = new SqlConnection();
            sqlConnection2.ConnectionString = Connection.conM();
            SqlDataAdapter da = new SqlDataAdapter(@"select  E.EmployeeID AS EmployeeID,FirstName+' '+LastName as [ad Soyad], COUNT(*) as [Toplam Sat��]                                   from Employees e inner join Orders ord 
                                                on ord.EmployeeID = e.EmployeeID
                                                group by e.EmployeeID, FirstName + ' ' + LastName", sqlConnection2);
            // SqlDataAdapter disconnection bir yap�d�r. sorgu i�lemleri ile veri �ekmemizi sa�lar.
            // sorguyu g�rmek isteersen. Adapter a breakpoint at ve da n�n �st�ne gel select command=>command text ile ula�.
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
            // SqlDataAdapter disconnection bir yap�d�r. sorgu i�lemleri ile veri �ekmemizi sa�lar.
            // sorguyu g�rmek isteersen. Adapter a breakpoint at ve da n�n �st�ne gel select command=>command text ile ula�.
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = dt;
        }
    }
}