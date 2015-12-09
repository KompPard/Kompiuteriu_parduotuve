﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kompiuteriu_parduotuve
{
    class Category : IDisposable
    {
        int id;
        string name;
        bool createORdelete=false;
        public Category(bool createORdelete)
        {
            this.createORdelete = createORdelete;
        }
        public void set(int id, string name,Database DB)
        {
            this.id = id;
            this.name = name;
            if (createORdelete == true)
                create(DB);
            else
                update(DB);
        }
        private void create(Database DB)
        {
            DB.Connect();
            DB.cmd = new System.Data.SqlClient.SqlCommand("INSERT INTO dbo.Category(name) values ('" + name + "')", DB.conn);
            DB.cmd.ExecuteNonQuery();
        }
       
        private void update(Database DB)
        {
            DB.Connect();
            DB.cmd = new System.Data.SqlClient.SqlCommand("UPDATE dbo.Category SET name = @name where id=@ID", DB.conn);
            DB.cmd.Parameters.AddWithValue("@name", name);
            DB.cmd.Parameters.AddWithValue("@ID", id);
            DB.cmd.ExecuteNonQuery();
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
