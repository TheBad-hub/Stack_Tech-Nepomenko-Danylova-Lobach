﻿using AtmLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class WithdrawForm : Form
    {
        private Account currentAccount;

        public WithdrawForm(Account account)
        {
            InitializeComponent();
            currentAccount = account;
        }
    }
}
