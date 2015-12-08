using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
namespace Kompiuteriu_parduotuve
{
    class Database
    {
        public SqlConnection conn = null; 
       public SqlDataAdapter adapter = null;
       public DataTable dt = null;
        public SqlCommand cmd = null;

        public Database()
        {
            conn= new SqlConnection(ConfigurationManager.ConnectionStrings["Connection.Properties.Settings.DBConnString"].ConnectionString); 
        }
        public void Connect()
        {
            if (conn != null && conn.State == ConnectionState.Closed)
            {
                conn.Open();

            }
        }
        
    }
}
