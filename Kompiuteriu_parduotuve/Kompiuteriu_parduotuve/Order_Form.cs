using System;
using System.Data;
using System.Windows.Forms;

namespace Kompiuteriu_parduotuve
{
    public partial class Order_Form : Form
    {
        DataTable dt = new DataTable();
        public Order_Form()
        {
            InitializeComponent();
        }
        private void Order_Form_Load(object sender, EventArgs e)
        {
            using (Cart cart = new Cart())
            {
                dt = cart.view_cart(Main_Form.cart_id);
                foreach (DataRow dr in dt.Rows)
                {
                    order_cart_Datagrid.Rows.Add(dr.ItemArray);
                }
                total_price_label.Text += dt.Compute("SUM(" + dt.Columns[4].ColumnName + ")", string.Empty).ToString();
                cart_guid_label.Text += dt.Rows[0][2].ToString();
            }
        }
        private void save_order_button_Click(object sender, EventArgs e)
        {
            using (Order order = new Order())
            {
                if (order.order(card_number_textbox.Text, Convert.ToInt16(exp_year_textbox.Text), Convert.ToInt16(exp_month_textbox.Text), Convert.ToInt16(cvc_textbox.Text), dt.Rows[0][2].ToString()))
                {
                    MessageBox.Show("Užsakymas pateiktas");
                    Main_Form main = new Main_Form();
                    main.Show();
                    Close();
                }
                else
                    MessageBox.Show("Klaida");
            }
        }
        private void cancel_order_button_Click(object sender, EventArgs e)
        {
            Main_Form main = new Main_Form();
            main.Show();
            Close();
        }
    }
}
