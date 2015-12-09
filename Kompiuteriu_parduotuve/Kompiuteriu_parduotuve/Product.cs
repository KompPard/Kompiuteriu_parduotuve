using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace Kompiuteriu_parduotuve
{
    class Product : IDisposable
    {
        string id, name, category, price, description;
        Database DB = new Database();
        List<string> ID_list = new List<string>();
        public void set(string name, string category, string price, string description)
        {
            
            this.name = name;
            this.category = category;
            this.price = price;
            this.description = description;
            save();
        }
        
        public void set(int ID)// trinimui overload
        {
            delete();
        }
        private void save()
        {
            /*  try
              {
                  DB.Connect(); //asociacija
                  DB.cmd = new System.Data.SqlClient.SqlCommand("INSERT INTO dbo.Users(ID,username,password,type) values (" + ID + ",'" + username + "','" + password + "'," + type + ")", DB.conn);
                  DB.cmd.ExecuteNonQuery();
              }
              catch (Exception ex)
              {
                  Console.WriteLine(ex);
                  return false;
              }*/
            DB.Connect();
            DB.cmd = new System.Data.SqlClient.SqlCommand("INSERT INTO dbo.Product(name,category,price,description) values ('" + name + "'," + category + ",'" + price + "','" + description + "')", DB.conn);
            DB.cmd.ExecuteNonQuery();
        }
        private void delete()
        {

        }
        public DataTable Fill_table(DataTable dt)
        {
            DB.adapter = new System.Data.SqlClient.SqlDataAdapter("Select * From dbo.Product", DB.conn);
            DB.dt = new System.Data.DataTable();
            DB.adapter.Fill(DB.dt);

            return DB.dt;
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
