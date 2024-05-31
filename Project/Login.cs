using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            loginText.Clear();
            passText.Clear();
        }

        private void loginText_Click(object sender, EventArgs e)
        {
            if (loginText.Text == "Enter your staff ID here")
            {
                loginText.Text = "";
            }
        }

        private void passText_Click(object sender, EventArgs e)
        {
            if (passText.Text == "Enter your password here")
            {
                passText.Text = "";
                passText.PasswordChar = '*';
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            Register registerForm = new Register();
            registerForm.Show();
            this.Hide();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (true) // if entered account & password are correct, go to another page. Else, display re-attempt alert
            {

            }
        }

        private void guestLogin_Click(object sender, EventArgs e)
        {
            // login as guest
        }
    }
}
