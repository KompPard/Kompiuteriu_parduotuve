using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kompiuteriu_parduotuve
{
    class User
    {
        Database DB;
        bool logged_in = false;
        string ID, username, password, type;
       public User(Database DB)
        {
           this.DB = DB; //Agregacija    
        }
        public bool User_conn(string name, string pass)
        {
            DB = new Database();
            DB.adapter = new System.Data.SqlClient.SqlDataAdapter("Select ID,username, password,type From dbo.Users where username='" + name + "' and password='" + pass + "'", DB.conn);
            DB.dt = new System.Data.DataTable();
            DB.adapter.Fill(DB.dt);

            if (DB.dt.Rows.Count == 1)
            {
                ID = DB.dt.Rows[0][0].ToString();
                username= DB.dt.Rows[0][1].ToString();
                password= DB.dt.Rows[0][2].ToString();
                type= DB.dt.Rows[0][3].ToString();
                logged_in = true;
                return true;
            }
            return false;
        }
        public void create_set(int ID, string username, string password, int type)
        {
            this.ID = ID.ToString();
            this.username = username;
            this.password = password;
            this.type = type.ToString();
            create();
        }
        private bool create()
        {
            try {
                DB.Connect();
                DB.cmd = new System.Data.SqlClient.SqlCommand("INSERT INTO dbo.Users(ID,username,password,type) values (" + ID + ",'" + username + "','" + password + "'," + type + ")", DB.conn);
                DB.cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
            
            return true;
        }
        public bool update(int ID, string username, string password)
        {
            try
            {
                DB.Connect();
                DB.cmd = new System.Data.SqlClient.SqlCommand("UPDATE dbo.Users SET username = @username, password = @password where ID=@ID", DB.conn);
                DB.cmd.Parameters.AddWithValue("@username", username);
                DB.cmd.Parameters.AddWithValue("@password", password);
                DB.cmd.Parameters.AddWithValue("@ID", ID);
                DB.cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}
