using System;
using System.Collections.Generic;
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
        public void set(int id,string name, string price, string description)
        {
            this.id = id.ToString();
            this.name = name;
            this.price = price;
            this.description = description;
            update();
        }
        public void set(int ID)// trinimui overload
        {
            id = ID.ToString();
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
            DB.cmd = new System.Data.SqlClient.SqlCommand("INSERT INTO dbo.Product(name,category,price,description) values ('" + name + "','" + category + "','" + price + "','" + description + "')", DB.conn);
            DB.cmd.ExecuteNonQuery();
        }
        private void delete()
        {
            DB.Connect();
            DB.cmd = new System.Data.SqlClient.SqlCommand("DELETE FROM dbo.Product WHERE ID="+ id +"", DB.conn);
            DB.cmd.ExecuteNonQuery();
        }
        private void update()
        {
            DB.Connect();
            DB.cmd = new System.Data.SqlClient.SqlCommand("UPDATE dbo.Product SET name = @name, price = @price, description=@description where ID=@ID", DB.conn);
            DB.cmd.Parameters.AddWithValue("@name", name);
            DB.cmd.Parameters.AddWithValue("@price", price);
            DB.cmd.Parameters.AddWithValue("@description", description);
            DB.cmd.Parameters.AddWithValue("@ID", id);
            DB.cmd.ExecuteNonQuery();
        }
        public DataTable Fill_table(DataTable dt,bool admin_ne)
        {
            string admin = "SELECT * FROM dbo.Product",
                   user = "Select pro.ID, pro.name, cat.name, pro.price, pro.description  From dbo.Product pro INNER JOIN dbo.Category cat ON pro.category=cat.id";
            if (admin_ne == true)
                DB.adapter = new System.Data.SqlClient.SqlDataAdapter(admin, DB.conn);
            else 
                DB.adapter = new System.Data.SqlClient.SqlDataAdapter(user, DB.conn);
            DB.dt = new DataTable();
            DB.adapter.Fill(DB.dt);
            return DB.dt;
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
