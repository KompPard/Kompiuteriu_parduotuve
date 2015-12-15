using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kompiuteriu_parduotuve
{
    class Search : IDisposable
    {
        Database DB = new Database();
        public Search()
        {
            DB.dt = new DataTable();
        }
        public DataTable search()
        {
            try
            {
                DB.Connect();
                DB.adapter = new SqlDataAdapter("SELECT * FROM dbo.Product", DB.conn);
                DB.adapter.Fill(DB.dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return DB.dt;
        }
        public DataTable search(string name)
        {
            try
            {
                DB.Connect();
                DB.adapter = new SqlDataAdapter("SELECT * FROM dbo.Product WHERE name LIKE '%" + name + "%'", DB.conn);
                DB.adapter.Fill(DB.dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return DB.dt;
        }
        public DataTable search(int category)
        {
            try
            {
                DB.Connect();
                DB.adapter = new SqlDataAdapter("SELECT * FROM dbo.Product WHERE category=" + category + "", DB.conn);
                DB.adapter.Fill(DB.dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return DB.dt;
        }
        public DataTable search(string name, int category)
        {
            try
            {
                DB.Connect();
                DB.adapter = new SqlDataAdapter("SELECT * FROM dbo.Product WHERE name LIKE '%" + name + "%' AND category=" + category + "", DB.conn);
                DB.adapter.Fill(DB.dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return DB.dt;
        }
        public DataTable find_id(int product_id)
        {
            try
            {
                DB.Connect();
                DB.adapter = new SqlDataAdapter("SELECT * FROM dbo.Product WHERE ID=" + product_id + "", DB.conn);
                DB.adapter.Fill(DB.dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return DB.dt;
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
