using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kompiuteriu_parduotuve
{
    class Order : IDisposable
    {
        Database DB = new Database();
        public bool order(string card, int exp_year, int exp_month, int cvc, string cart_id)
        {
            try
            {
                DB.Connect();
                DB.cmd = new SqlCommand("INSERT INTO dbo.Orders(date,card_number,exp_year,exp_month,cvc,order_state,cart_id) VALUES ('" + DateTime.Now + "','" + card + "'," + exp_year +"," + exp_month +"," + cvc +"," + 0 +",'" + cart_id +"')", DB.conn);
                DB.cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return true;
        }
        public DataTable show_orders() //Visi orderiai (admin paneliui)
        {
            try
            {
                DB.Connect();
                DB.adapter = new SqlDataAdapter("SELECT * FROM dbo.Orders", DB.conn);
                DB.dt = new DataTable();
                DB.adapter.Fill(DB.dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return DB.dt;
        }
        public DataTable show_orders(string cart_id) //Specifinio userio orderis
        {
            try
            {
                DB.Connect();
                DB.adapter = new SqlDataAdapter("SELECT * FROM dbo.Orders WHERE cart_id='" + cart_id + "'", DB.conn);
                DB.dt = new DataTable();
                DB.adapter.Fill(DB.dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return DB.dt;
        }
        //public DataTable show_order_cart(string cart_id)
        //{
        //    try
        //    {
        //        DB.Connect();
        //        DB.adapter = new SqlDataAdapter("SELECT * FROM dbo.Cart WHERE guid='" + cart_id + "'", DB.conn);
        //        DB.dt = new DataTable();
        //        DB.adapter.Fill(DB.dt);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    return DB.dt;
        //}
        public bool status(int value, string cart_id)
        {
            try
            {
                DB.Connect();
                DB.cmd = new SqlCommand("UPDATE dbo.Orders SET status=" + value + " WHERE cart_id='" + cart_id + "'", DB.conn);
                DB.cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
