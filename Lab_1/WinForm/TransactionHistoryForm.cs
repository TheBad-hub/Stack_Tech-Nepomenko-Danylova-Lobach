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
    public partial class TransactionHistoryForm : Form
    {
        private List<Transaction> transactions;
        public TransactionHistoryForm(List<Transaction> transactions)
        {
            InitializeComponent();
            this.transactions = transactions;

            cmbFilter.Items.Add("За поточний день");
            cmbFilter.Items.Add("За поточний тиждень");
            cmbFilter.Items.Add("За поточний місяць");
            cmbFilter.SelectedIndex = 0;

            // Подписка на событие изменения фильтра
            cmbFilter.SelectedIndexChanged += CmbFilter_SelectedIndexChanged;

            UpdateTransactionHistory(transactions);
        }
    }
}
