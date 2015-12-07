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
            login_state=DB.User_conn(username_textbox.Text, password_textbox.Text);
            if (login_state == true)
                Console.WriteLine(login_state);
        }
    }
}
