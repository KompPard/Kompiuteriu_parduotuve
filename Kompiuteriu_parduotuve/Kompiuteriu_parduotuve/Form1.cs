using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kompiuteriu_parduotuve
{
    public partial class Form1 : Form
    {
        string product_selected_id = "";
        DataTable dt = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            new Login_Form().Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refresh_table();
           
        }
        private void refresh_table()
        {
            products_Datagrid.Rows.Clear();
            using (Product product = new Product())
            {
                dt = product.Fill_table(dt,false);
                foreach (DataRow dr in dt.Rows)
                {

                    products_Datagrid.Rows.Add(dr.ItemArray);

                }
            }

        }

        private void products_Datagrid_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in products_Datagrid.SelectedRows)
            {
                product_selected_id = row.Cells[0].Value.ToString();
                products_description.Text= row.Cells[4].Value.ToString();
            }
            Console.Write(product_selected_id);
        }
    }
}
