using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kompiuteriu_parduotuve
{
    class Comment : Commenting
    {
        int id;
        string author, message;
        
        public override void delete(int id)
        {
            using (Database DB = new Database())
            {
                DB.Connect();
                DB.cmd = new System.Data.SqlClient.SqlCommand("DELETE FROM dbo.Comment WHERE id=" + id + "", DB.conn);
                DB.cmd.ExecuteNonQuery();
            }
        }

        public override void save(string author, string message, int product_id)
        {
            using (Database DB = new Database())
            {
                DB.Connect();
                DB.cmd = new System.Data.SqlClient.SqlCommand("INSERT INTO dbo.Comment(author,message,product_id) values ('" + author + "','" + message + "'," + product_id + ")", DB.conn);
                DB.cmd.ExecuteNonQuery();
            }
        }
        public override DataTable get(DataTable dt, int product_id)
        {
            using (Database DB = new Database()) {
                DB.adapter = new System.Data.SqlClient.SqlDataAdapter("SELECT id,author, message from dbo.Comment where product_id="+product_id+"", DB.conn);
                DB.dt = new System.Data.DataTable();
                DB.adapter.Fill(DB.dt);

                return DB.dt;
            }
        }
    }
}
