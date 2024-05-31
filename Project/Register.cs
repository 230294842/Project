﻿using System;
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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            // Function of checking the confirm password was match or not
            if (passText.Text == passText.Text) // if true (both password are the same)
            {
                // go to success form

            } else // if false (both password wasn't same)
            {
                // re-enter
            }

            if (true) // if entered account & password are correct, go to another page. Else, display re-attempt alert
            {

            }
        }

        private void confirmPass_TextChanged(object sender, EventArgs e)
        {
            if (passText.Text == "Confirm your password here")
            {
                passText.Text = "";
                passText.PasswordChar = '*';
            }
        }
    }
}