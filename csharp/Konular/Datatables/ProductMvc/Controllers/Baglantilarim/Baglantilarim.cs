using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductMvc.Controllers
{
    public class Baglantilarim
    {
        public static string connectionString = @"Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;";

        public string Con()
        {
             string con= @"Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;";
            return con;
           
        }
    }
}
