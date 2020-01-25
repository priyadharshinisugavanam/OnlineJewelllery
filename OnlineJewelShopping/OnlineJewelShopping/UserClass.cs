using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace OnlineJewelShopping
{
    interface InterfaceforDetailWindow
    {
        void Login();

    }
    public class UserClass 
    {

        public string userName { get; set; }
        public string phoneNumber { get; set; }
        public string mailId { get; set; }
        public string password { get; set; }
        public string conformPassword { get; set; }




    }
    class Connection
    {
        public static SqlConnection getDetails()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            return sqlConnection;
        }
    }

}
