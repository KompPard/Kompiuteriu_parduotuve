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
    public partial class Admin_form : Form
    {
        string product_selected_id = "";
        int veiksmas = 0;
        DataTable dt = new DataTable();
        public Admin_form()
        {
            InitializeComponent();
        }

        private void hide_button_Click(object sender, EventArgs e)
        {
            HIDE();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            veiksmas = 0;
            SHOW();
        }

        private void confirm_button_Click(object sender, EventArgs e)
        {
            
            Database DB = new Database();
            User user = new User(DB);
            if (veiksmas == 0)
            {
                user.create_set(int.Parse(ID_textbox.Text), username_textbox.Text, password_textbox.Text, int.Parse(type_textbox.Text));
            }
            else if (veiksmas == 1)
            {
                user.update(int.Parse(ID_textbox.Text), username_textbox.Text, password_textbox.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SHOW();
            veiksmas = 1;
            type_textbox.Visible = false;
            
        }
        void HIDE()
        {
            ID_textbox.Visible = false;
            username_textbox.Visible = false;
            password_textbox.Visible = false;
            type_textbox.Visible = false;
            confirm_worker_button.Visible = false;
            hide_button.Visible = false;
        }
        void SHOW()
        {
            ID_textbox.Visible = true;
            username_textbox.Visible = true;
            password_textbox.Visible = true;
            type_textbox.Visible = true;
            confirm_worker_button.Visible = true;
            hide_button.Visible = true;
        }

        private void product_confirm_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.set(product_name_textbox.Text, product_category_textbox.Text, product_price_textbox.Text, product_description_textbox.Text);
        }

        private void Admin_form_Load(object sender, EventArgs e)
        {
            refresh_table();
        }

        private void product_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void product_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void refresh_table()
        {
            product_grid.Rows.Clear();
            using (Product product = new Product())
            {
                dt = product.Fill_table(dt);
                foreach (DataRow dr in dt.Rows)
                {

                    product_grid.Rows.Add(dr.ItemArray);

                }
            }

        }
        private void product_grid_SelectionChanged(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in product_grid.SelectedRows)
            {
                product_selected_id = row.Cells[0].Value.ToString();
                product_name_textbox.Text= row.Cells[1].Value.ToString();
                product_category_textbox.Text= row.Cells[2].Value.ToString();
                product_price_textbox.Text = row.Cells[3].Value.ToString();
                product_description_textbox.Text = row.Cells[4].Value.ToString();
                Console.WriteLine(product_selected_id);
            }
            
            
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            using (Product product = new Product())
            {
                product.set(int.Parse(product_selected_id), product_name_textbox.Text, product_price_textbox.Text, product_description_textbox.Text);
                refresh_table();
                
            }
        }
    }
}
