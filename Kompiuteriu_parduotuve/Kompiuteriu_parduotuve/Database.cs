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
        SqlConnection conn= new SqlConnection(ConfigurationManager.ConnectionStrings["Connection.Properties.Settings.DBConnString"].ConnectionString);
        SqlDataAdapter adapter = null;
        DataTable dt = null;
        public void Connect()
        {
            if (conn != null && conn.State == ConnectionState.Closed)
            {
                conn.Open();

            }
        }
        public bool User_conn(string name, string pass)
        {
            adapter= new SqlDataAdapter("Select username, password From dbo.Users where username='" + name + "' and password='"+pass+"'",conn);
            dt = new DataTable();
            adapter.Fill(dt);
           
            if (dt.Rows.Count ==1)
                return true;      
            
            return false;
        }
    }
}
