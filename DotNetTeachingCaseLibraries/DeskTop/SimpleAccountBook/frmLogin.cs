﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace SimpleAccountBook
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //清空输入框，把焦点设在用户名上
            txbUserName.Clear();
            txbPassword.Clear();
            txbUserName.Focus();
        }
        /// <summary>
        /// 用户姓名
        /// </summary>
        public string LoginName
        {
            get;
            private set;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var bllHandler = new BllHandler();
            LoginName = bllHandler.Login(txbUserName.Text, txbPassword.Text);
        }
    }
}
