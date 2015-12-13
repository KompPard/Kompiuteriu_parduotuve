using System;
using System.Data;
using System.Windows.Forms;

namespace Kompiuteriu_parduotuve
{
    class Cart : IDisposable
    {
        Database DB = new Database();
        public bool add(int product_id, int quantity)
        {
            try
            {
                DB.Connect();
                DB.cmd = new System.Data.SqlClient.SqlCommand("IF NOT EXISTS(SELECT product_id FROM dbo.Cart WHERE product_id=" + product_id + ") INSERT INTO dbo.Cart(product_id,quantity) values ('" + product_id + "','" + quantity + "') ELSE UPDATE dbo.Cart SET quantity=quantity+1 WHERE product_id=" + product_id + "", DB.conn);
                DB.cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return true;
        }
        public bool remove(int product_id)
        {
            try
            {
                DB.Connect();
                DB.cmd = new System.Data.SqlClient.SqlCommand("DELETE FROM dbo.Cart WHERE ID=" + product_id + "", DB.conn);
                DB.cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }
        public DataTable view_cart()
        {
            try
            {
                DB.Connect();
                DB.adapter = new System.Data.SqlClient.SqlDataAdapter("SELECT name, dbo.Cart.Id, product_id, quantity, price*quantity FROM dbo.Cart LEFT JOIN dbo.Product ON dbo.Cart.product_id=dbo.Product.ID", DB.conn);
                DB.dt = new DataTable();
                DB.adapter.Fill(DB.dt);   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return DB.dt;
        }
        public bool clear_cart()
        {
            try
            {
                DB.Connect();
                DB.cmd = new System.Data.SqlClient.SqlCommand("DELETE FROM dbo.Cart", DB.conn);
                DB.cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }
        public DataTable export_from_datagrid(DataGridView dgv)
        {
            DataTable dt = new DataTable();
            foreach (DataGridViewColumn col in dgv.Columns)
            {
                DataColumn dc = new DataColumn(col.Name.ToString());
                dt.Columns.Add(dc);
            }
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                DataGridViewRow row = dgv.Rows[i];
                DataRow dr = dt.NewRow();
                for (int j = 0; j < dgv.Columns.Count - 1; j++)
                {
                    dr[j] = row.Cells[j].Value;
                }
                dt.Rows.Add(dr);
            }
            return dt;
        }
        public void refill_cart_table(DataGridView dgv)
        {
            if (dgv.Rows.Count > 0)
            {
                DataTable dt = export_from_datagrid(dgv);
                dt.Rows.Remove(dt.Rows[dt.Rows.Count - 1]);
                using (Cart cart = new Cart())
                {
                    cart.clear_cart();
                    foreach (DataRow dr in dt.Rows)
                    {
                        cart.add(Convert.ToInt16(dr[2]), Convert.ToInt16(dr[3]));
                    }
                }
            }
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
