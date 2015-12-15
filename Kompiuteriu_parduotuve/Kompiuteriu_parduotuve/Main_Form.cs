using System;
using System.Data;
using System.Windows.Forms;

namespace Kompiuteriu_parduotuve
{
    public partial class Main_Form : Form
    {
        public static string cart_id;
        string product_selected_id = "";
        DataTable dt = null;
        public Main_Form()
        {
            InitializeComponent();
        }
        private void Login_button_Click(object sender, EventArgs e)
        {
            new Login_Form().Show();
            Hide();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cart_id = Helper.getNewCartGUID();
            refresh_table();
            refresh_reviews();
            show_contacts();
            fill_category_dropdown();
            search_category_box.SelectedIndex = search_category_box.Items.Count - 1;
        }
        private void show_contacts()
        {
            using (Contacts contacts = new Contacts(new Database()))
            {
                dt = contacts.show();
                contacts_box.Text = dt.Rows[0][1].ToString() + "\n" 
                + dt.Rows[0][2].ToString() + "\n" + dt.Rows[0][3].ToString() + "\n" 
                + dt.Rows[0][4].ToString() + "\n" + dt.Rows[0][5].ToString();
            }
        }
        private void clear_cart()
        {
            using (Cart cart = new Cart())
            {
                cart.clear_cart(cart_id);
                cart.view_cart(cart_id);
            }
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
        private void refresh_cart_table()
        {
            cart_Datagrid.Rows.Clear();
            using (Cart cart = new Cart())
            {
                dt = cart.view_cart(cart_id);
                foreach (DataRow dr in dt.Rows)
                {
                    cart_Datagrid.Rows.Add(dr.ItemArray);
                }
            }
        }
        public void refresh_reviews()
        {
            using (Commenting comm = new Review())
            {
                int i = 0;
                dt = comm.get(dt, 1);//1 del vaizdo
                foreach (DataRow dr in dt.Rows)
                {
                    user_reviews.AppendText(dt.Rows[i].Field<string>("author"));
                    user_reviews.AppendText(": ");
                    user_reviews.AppendText(dt.Rows[i].Field<string>("message"));
                    user_reviews.AppendText("\n");
                    i++;
                }
            }
        }
        private void products_Datagrid_SelectionChanged(object sender, EventArgs e)
        {
            dt = new DataTable();
            user_comments.Text = "";
            foreach (DataGridViewRow row in products_Datagrid.SelectedRows)
            {
                product_selected_id = row.Cells[0].Value.ToString();
                products_description.Text = row.Cells[4].Value.ToString();
                using(Commenting comm = new Comment())
                {
                    int i = 0;
                    dt = comm.get(dt, int.Parse(product_selected_id));
                    foreach (DataRow dr in dt.Rows)
                    {
                        //products_Datagrid.Rows.Add(dr.ItemArray);
                        user_comments.AppendText(dt.Rows[i].Field<string>("author"));
                        user_comments.AppendText(": ");
                        user_comments.AppendText(dt.Rows[i].Field<string>("message"));
                        user_comments.AppendText("\n");
                        i++;
                    }
                }
            }
            Console.Write(product_selected_id);
        }
        private void confirm_comment_Click(object sender, EventArgs e)
        {
            using(Commenting comm = new Comment())
            {
                comm.save(username_textbox.Text, comment_textbox.Text, int.Parse(product_selected_id));
            }
        }
        private void confirm_review_Click(object sender, EventArgs e)
        {
            using (Commenting comm = new Review())
            {
                comm.save(review_username_textbox.Text, review_message_textbox.Text, 1);//1 nes reikia kazka stumt, nors nenaudoja
                user_reviews.Text = "";
                refresh_reviews();
            }
        }
        private void add_to_cart_button_Click(object sender, EventArgs e)
        {
            using (Cart cart = new Cart())
            {
                cart.add(Convert.ToInt16(products_Datagrid.SelectedRows[0].Cells[0].Value), 1, cart_id); //1 default
            }
            refresh_cart_table();
        }
        private void cart_Datagrid_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            using (Cart cart = new Cart())
            {
                cart.refill_cart_table(cart_Datagrid, cart_id);
            }
        }
        private void order_button_Click(object sender, EventArgs e)
        {
            new Order_Form().Show();
            Hide();
        }
        private void clear_cart_button_Click(object sender, EventArgs e)
        {
            clear_cart();
            refresh_cart_table();
        }
        private void search_button_Click(object sender, EventArgs e)
        {
            using (Search search = new Search())
            {
                if (search_name_box.Text == "" && (int)search_category_box.SelectedValue == -1)
                    dt = search.search();
                else if (search_name_box.Text != "" && (int)search_category_box.SelectedValue == -1)
                    dt = search.search(search_name_box.Text);
                else if (search_name_box.Text == "" && (int)search_category_box.SelectedValue != -1)
                    dt = search.search((int)search_category_box.SelectedValue);
                else
                    dt = search.search(search_name_box.Text, (int)search_category_box.SelectedValue);
                refill_search_table(dt);
            }
        }
        private void fill_category_dropdown()
        {
            using (Database DB = new Database())
            {
                using (Category category = new Category(false))
                {
                    DataTable comb_dt;
                    comb_dt = category.display_combobox(DB);
                    comb_dt.Rows.Add(-1, "Visos kategorijos");
                    foreach (DataRow dr in comb_dt.Rows)
                    {
                        search_category_box.DataSource = comb_dt;
                        search_category_box.DisplayMember = "name";
                        search_category_box.ValueMember = "id";
                    }
                }
            }
        }
        private void refill_search_table(DataTable results)
        {
            search_results_Datagrid.Rows.Clear();
            foreach (DataRow dr in results.Rows)
            {
                search_results_Datagrid.Rows.Add(dr.ItemArray);
            }
        }
        private void search_results_Datagrid_SelectionChanged(object sender, EventArgs e)
        {
            search_results_desc_box.Text = "";
            if (search_results_Datagrid.Rows.Count > -1 && search_results_Datagrid.SelectedRows.Count > 0)
            {
                search_results_desc_box.Text = search_results_Datagrid.SelectedRows[0].Cells[4].Value.ToString();
            }
        }

        private void search_add_to_cart_button_Click(object sender, EventArgs e)
        {
            using (Cart cart = new Cart())
            {
                cart.add(Convert.ToInt16(search_results_Datagrid.SelectedRows[0].Cells[0].Value), 1, cart_id);
            }
            refresh_cart_table();
        }

        private void compare_button_Click(object sender, EventArgs e)
        {
            if (search_results_Datagrid.SelectedRows.Count == 2)
            {
                using (Compare compare = new Compare(Convert.ToInt16(search_results_Datagrid.SelectedRows[0].Cells[0].Value), Convert.ToInt16(search_results_Datagrid.SelectedRows[1].Cells[0].Value)))
                {
                    dt = compare.compare();
                    product1_box.Text = dt.Rows[0][1] + "\nKaina: " + dt.Rows[0][3] + "\nAprašymas: " + dt.Rows[0][4];
                    product1_box.Tag = dt.Rows[0][0];
                    product2_box.Text = dt.Rows[1][1] + "\nKaina: " + dt.Rows[1][3] + "\nAprašymas: " + dt.Rows[1][4];
                    product2_box.Tag = dt.Rows[1][0];
                }
            }
            else
                MessageBox.Show("Norint palyginti reikia pasirinkti dvi prekes");
        }
        private void swap_button_Click(object sender, EventArgs e)
        {
            using (Compare compare = new Compare(Convert.ToInt16(product1_box.Tag), Convert.ToInt16(product2_box.Tag)))
            {
                dt = compare.change_sides();
                product1_box.Text = dt.Rows[0][1] + "\nKaina: " + dt.Rows[0][3] + "\nAprašymas: " + dt.Rows[0][4];
                product1_box.Tag = dt.Rows[0][0];
                product2_box.Text = dt.Rows[1][1] + "\nKaina: " + dt.Rows[1][3] + "\nAprašymas: " + dt.Rows[1][4];
                product2_box.Tag = dt.Rows[1][0];
            }
        }
    }
}
