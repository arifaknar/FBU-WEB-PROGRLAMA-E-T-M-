using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ProductMvc.Controllers
{
    public class ProductManager
    {

        public DataTable UrunleriGetir(string kategori,SqlConnection sqlConnection)
        {
            DataTable dataTable= new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(@$"select CategoryName from Categories",sqlConnection);
            da.Fill(dataTable);
            return dataTable;
        }
        
    }
}
