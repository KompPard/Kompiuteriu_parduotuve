using System;
using System.Data;

namespace Kompiuteriu_parduotuve
{
    class Contacts : IDisposable
    {
        Database DB;
        public Contacts(Database DB)
        {
            this.DB = DB;
        }
        public DataTable show()
        {
            try
            {
                DB.Connect();
                DB.adapter = new System.Data.SqlClient.SqlDataAdapter("SELECT * FROM dbo.Contacts", DB.conn);
                DB.dt = new DataTable();
                DB.adapter.Fill(DB.dt);
            }
            catch (Exception ex)
            {
                
            }
            return DB.dt;
        }
        public bool update(string company, string address, string phone, string email, string owner)
        {
            try
            {
                DB.Connect();
                DB.cmd = new System.Data.SqlClient.SqlCommand("UPDATE dbo.Contacts SET company = @company, address = @address, phone = @phone, email = @email, owner = @owner", DB.conn);
                DB.cmd.Parameters.AddWithValue("@company", company);
                DB.cmd.Parameters.AddWithValue("@address", address);
                DB.cmd.Parameters.AddWithValue("@phone", phone);
                DB.cmd.Parameters.AddWithValue("@email", email);
                DB.cmd.Parameters.AddWithValue("@owner", owner);
                DB.cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
