using System;
using System.Windows.Forms;

namespace Kompiuteriu_parduotuve
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }
        private void Login_Click(object sender, EventArgs e)
        {
            bool login_state=false;
            Database DB = new Database();
            User user = new User(DB);
            login_state=user.User_conn(username_textbox.Text, password_textbox.Text);
            if (login_state == true)
            {
                new Admin_Form().Show();
                Close();
            }
        }
        private void main_form_button_Click(object sender, EventArgs e)
        {
            Main_Form main_form = new Main_Form();
            main_form.Show();
            Close();
        }
    }
}
