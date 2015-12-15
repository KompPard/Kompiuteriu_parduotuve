using System;
using System.Data;
using System.Windows.Forms;

namespace Kompiuteriu_parduotuve
{
    public partial class Admin_Form : Form
    {
        string product_selected_id = "", product_comment_id="", review_id="";
        int action = 0;
        DataTable dt = new DataTable();
        public Admin_Form()
        {
            InitializeComponent();
        }
        private void hide_button_Click(object sender, EventArgs e)
        {
            HIDE();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            action = 0;
            SHOW();
        }
        private void confirm_button_Click(object sender, EventArgs e)
        {
            Database DB = new Database();
            User user = new User(DB);
            if (action == 0)
            {
                user.create_set(int.Parse(ID_textbox.Text), username_textbox.Text, password_textbox.Text, int.Parse(type_textbox.Text));
            }
            else if (action == 1)
            {
                user.update(int.Parse(ID_textbox.Text), username_textbox.Text, password_textbox.Text);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SHOW();
            action = 1;
            type_textbox.Visible = false;
        }
        private void product_confirm_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.set(product_name_textbox.Text, product_category_comb.SelectedValue.ToString(), product_price_textbox.Text, product_description_textbox.Text);
            refresh_table();
        }
        private void Admin_form_Load(object sender, EventArgs e)
        {
            refresh_table();
            refresh_review_table();
            refresh_contacts_values();
            fill_orders();
            string[] status = { "Laukia", "Vykdomas", "Įvykdytas" };
            order_status_box.Items.AddRange(status);
            using (Database DB = new Database())
            {
                using (Category category = new Category(false))
                {
                    DataTable comb_dt;
                    comb_dt = category.display_combobox(DB);
                    foreach (DataRow dr in comb_dt.Rows)
                    {
                        product_category_comb.DataSource = comb_dt;
                        product_category_comb.DisplayMember = "name";
                        product_category_comb.ValueMember = "id";
                    }
                }
            }
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
                dt = product.Fill_table(dt,true);
                foreach (DataRow dr in dt.Rows)
                {
                    product_grid.Rows.Add(dr.ItemArray);
                }
            }
        }
        private void refresh_contacts_values()
        {
            using (Contacts contacts = new Contacts(new Database()))
            {
                dt = contacts.show();
                company_name_textbox.Text = dt.Rows[0][1].ToString();
                company_address_textbox.Text = dt.Rows[0][2].ToString();
                company_phone_textbox.Text = dt.Rows[0][3].ToString();
                company_email_textbox.Text = dt.Rows[0][4].ToString();
                company_owner_textbox.Text = dt.Rows[0][5].ToString();
            }
        }
        private void refresh_comment_table()
        {
            product_comment_datagrid.Rows.Clear();
            using (Commenting comm = new Comment())
            {
                dt = comm.get(dt, int.Parse(product_selected_id));
                foreach (DataRow dr in dt.Rows)
                {
                    product_comment_datagrid.Rows.Add(dr.ItemArray);
                }
            }
        }
        private void refresh_review_table()
        {
            review_datagrid.Rows.Clear();
            using (Commenting comm = new Review())
            {
                dt = comm.get(dt,1);//1 PLACEHOLDER
                foreach (DataRow dr in dt.Rows)
                {
                    review_datagrid.Rows.Add(dr.ItemArray);
                }
            }
        }
        private void product_grid_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in product_grid.SelectedRows)
            {
                product_selected_id = row.Cells[0].Value.ToString();
                product_category_comb.SelectedValue = row.Cells[2].Value.ToString();
                product_name_textbox.Text = row.Cells[1].Value.ToString();
                product_price_textbox.Text = row.Cells[3].Value.ToString();
                product_description_textbox.Text = row.Cells[4].Value.ToString();
                Console.WriteLine(product_selected_id);
                refresh_comment_table();
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
        private void delete_button_Click(object sender, EventArgs e)
        {
            using (Product product = new Product())
            {
                product.set(int.Parse(product_selected_id));
                refresh_table();
            }
        }
        private void confirm_category_Click(object sender, EventArgs e)
        {
            category_func(true);
        }
        private void update_category_Click(object sender, EventArgs e)
        {
            category_func(false);
        }
        private void category_func(bool action)
        {
            using (Database DB = new Database())
            {
                if (action == true)
                {
                    using (Category category = new Category(true))
                    {
                        category.set(0, category_name_textbox.Text, DB);
                    }
                }
                else
                {
                    using (Category category = new Category(false))
                    {
                        category.set(int.Parse(category_id_textobx.Text), category_name_textbox.Text, DB);
                    }
                }   
            }
        }
        private void product_category_comb_SelectedIndexChanged(object sender, EventArgs e)
        {
           Console.WriteLine(product_category_comb.SelectedValue);
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
        private void to_main_form_Click(object sender, EventArgs e)
        {
            Main_Form main = new Main_Form();
            main.Show();
            Close();
        }
        private void product_comment_datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void review_datagrid_SelectionChanged(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in review_datagrid.SelectedRows)
            {
                review_id =row.Cells[0].Value.ToString();
                Console.WriteLine(review_id);
            }
        }
        private void delete_review_button_Click(object sender, EventArgs e)
        {
            using (Commenting comm = new Review())
            {
                comm.delete(int.Parse(review_id));
                refresh_review_table();
            }
        }
        private void update_contacts_button_Click(object sender, EventArgs e)
        {
            using (Contacts contacts = new Contacts(new Database()))
            {
                contacts.update(company_name_textbox.Text, company_address_textbox.Text, company_phone_textbox.Text, company_email_textbox.Text, company_owner_textbox.Text);
            }
            refresh_contacts_values();
        }
        private void delete_comment_button_Click(object sender, EventArgs e)
        {
            using(Commenting comm=new Comment())
            {
                comm.delete(int.Parse(product_comment_id));
                refresh_comment_table();
            }
        }
        private void admin_orders_Datagrid_SelectionChanged(object sender, EventArgs e)
        {
            order_status_box.SelectedIndex = Convert.ToInt16(admin_orders_Datagrid.SelectedRows[0].Cells[6].Value);
            admin_cart_Datagrid.Rows.Clear();
            using (Cart cart = new Cart())
            {
                dt = cart.view_cart(admin_orders_Datagrid.SelectedRows[0].Cells[7].Value.ToString());
                foreach (DataRow dr in dt.Rows)
                {
                    admin_cart_Datagrid.Rows.Add(dr.ItemArray);
                }
            }
        }
        private void order_status_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            admin_orders_Datagrid.CurrentRow.Cells[6].Value = order_status_box.SelectedIndex;
            using (Order order = new Order())
            {
                order.status(order_status_box.SelectedIndex, admin_orders_Datagrid.CurrentRow.Cells[7].Value.ToString());
            }
        }
        private void product_comment_datagrid_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in product_comment_datagrid.SelectedRows)
            {
                product_comment_id = product_selected_id = row.Cells[0].Value.ToString();
                Console.WriteLine(product_comment_id);
            }
        }
        private void fill_orders()
        {
            using (Order order = new Order())
            {
                dt = order.show_orders();
                foreach (DataRow dr in dt.Rows)
                {
                    admin_orders_Datagrid.Rows.Add(dr.ItemArray);
                }
            }
        }
    }
}
