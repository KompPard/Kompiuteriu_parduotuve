using System;
using System.Data;
using System.Windows.Forms;

namespace Kompiuteriu_parduotuve
{
    public partial class Form1 : Form
    {
        string cart_id;
        string product_selected_id = "";
        DataTable dt = null;
        public Form1()
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
            cart_id = Guid.NewGuid().ToString();
            refresh_table();
            refresh_reviews();
            show_contacts();
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
                        // products_Datagrid.Rows.Add(dr.ItemArray);
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
                if(cart.add(Convert.ToInt16(products_Datagrid.SelectedRows[0].Cells[0].Value), 1, cart_id) == true) //1 default
                {
                    add_to_cart_label.ForeColor = System.Drawing.Color.Green;
                    add_to_cart_label.Text = "Pridėta";
                }
                else
                {
                    add_to_cart_label.ForeColor = System.Drawing.Color.Red;
                    add_to_cart_label.Text = "Klaida";
                }
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
    }
}
