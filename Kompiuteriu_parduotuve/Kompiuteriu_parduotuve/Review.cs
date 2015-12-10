using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kompiuteriu_parduotuve
{
    class Review : Commenting
    {
        public override void delete(int id)
        {
            throw new NotImplementedException();
        }

        public override DataTable get(DataTable dt, int product_id)
        {
            using (Database DB = new Database())
            {
                DB.adapter = new System.Data.SqlClient.SqlDataAdapter("SELECT author, message from dbo.Review", DB.conn);
                DB.dt = new System.Data.DataTable();
                DB.adapter.Fill(DB.dt);

                return DB.dt;
            }
        }

        public override void save(string author, string message, int product_id)
        {
            using (Database DB = new Database())
            {
                DB.Connect();
                DB.cmd = new System.Data.SqlClient.SqlCommand("INSERT INTO dbo.Review(author,message) values ('" + author + "','" + message +"')", DB.conn);
                DB.cmd.ExecuteNonQuery();
            }
        }
    }
}
