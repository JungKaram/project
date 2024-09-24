﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RM
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Let create database and user table

            if (MainClass.IsValidUser(txtUser.Text,txtPass.Text)==false)
            {
                guna2MessageDialog1.Show("invaild username or password");
                return;
            }
            else
            {
                this.Hide();
                frmMain frm= new frmMain();
                frm.Show();
            }

            //Let insert a user first
        }
    }
}
