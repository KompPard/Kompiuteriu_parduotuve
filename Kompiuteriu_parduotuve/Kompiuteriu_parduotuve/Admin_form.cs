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
        int veiksmas = 0;
        public Admin_form()
        {
            InitializeComponent();
        }

        private void hide_button_Click(object sender, EventArgs e)
        {
            ID_textbox.Visible = false;
            username_textbox.Visible = false;
            password_textbox.Visible = false;
            type_textbox.Visible = false;
            confirm_button.Visible = false;
            hide_button.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            veiksmas = 0;
            
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
            veiksmas = 1;
            type_textbox.Visible = false;
        }
    }
}
