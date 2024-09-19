using AtmLibrary;
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
    public partial class TransferForm : Form
    {
        private Account currentAccount;
        private Dictionary<string, Account> accounts;

        public TransferForm(Account account, Dictionary<string, Account> accounts)
        {
            InitializeComponent();
            currentAccount = account;
            this.accounts = accounts;
        }
    }
}
