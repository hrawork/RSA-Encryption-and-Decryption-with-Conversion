﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSA_Encryption_and_Decryption_with_Conversion
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin" && txtPassword.Text == "123")
            {
                MenuForm menu = new MenuForm();
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid credentials");
            }
        }
    }
}
