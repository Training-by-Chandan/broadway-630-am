﻿using MyDesktop.Service;
using MyDesktop.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDesktop
{
    public partial class Login : Form
    {
        private UserService userService = new UserService();

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var loginmodel = new LoginViewModel()
            {
                Username = txtUsername.Text,
                Password = txtPassword.Text
            };
            var res = userService.Login(loginmodel);
            if (res.Success)
            {
                MainForm m = new MainForm();
                m.MdiParent = this.MdiParent;
                m.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show(res.Message);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
        }
    }
}
