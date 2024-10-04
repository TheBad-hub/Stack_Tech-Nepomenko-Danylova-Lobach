using AtmLibrary;
using System.Security.Principal;

namespace WinForm
{
    partial class TransactionHistoryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionHistoryForm));
            cmbFilter = new ComboBox();
            lstTransactions = new ListBox();
            SuspendLayout();
            // 
            // cmbFilter
            // 
            cmbFilter.FormattingEnabled = true;
            cmbFilter.Location = new Point(250, 247);
            cmbFilter.Margin = new Padding(3, 2, 3, 2);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Size = new Size(215, 23);
            cmbFilter.TabIndex = 0;
            // 
            // lstTransactions
            // 
            lstTransactions.FormattingEnabled = true;
            lstTransactions.ItemHeight = 15;
            lstTransactions.Location = new Point(105, 76);
            lstTransactions.Margin = new Padding(3, 2, 3, 2);
            lstTransactions.Name = "lstTransactions";
            lstTransactions.Size = new Size(501, 79);
            lstTransactions.TabIndex = 1;
            // 
            // TransactionHistoryForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(716, 377);
            Controls.Add(lstTransactions);
            Controls.Add(cmbFilter);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TransactionHistoryForm";
            Text = "TransactionHistoryForm";
            ResumeLayout(false);
        }

        #endregion
        // Обновляем список транзакций в зависимости от выбранного фильтра
        private void CmbFilter_SelectedIndexChanged(object? sender, EventArgs e)
        {
            string selectedFilter = cmbFilter.SelectedItem.ToString();
            List<Transaction> filteredTransactions = new List<Transaction>();

            if (selectedFilter == "За поточний день")
            {
                filteredTransactions = TransactionFilters.FilterByCurrentDay(transactions);
            }
            else if (selectedFilter == "За поточний тиждень")
            {
                filteredTransactions = TransactionFilters.FilterByCurrentWeek(transactions);
            }
            else if (selectedFilter == "За поточний місяць")
            {
                filteredTransactions = TransactionFilters.FilterByCurrentMonth(transactions);
            }

            UpdateTransactionHistory(filteredTransactions);
        }

        private void UpdateTransactionHistory(List<Transaction> filteredTransactions)
        {
            lstTransactions.Items.Clear();
            foreach (var transaction in filteredTransactions)
            {
                lstTransactions.Items.Add(transaction.ToString());
            }
        }

        private ComboBox cmbFilter;
        private ListBox lstTransactions;
    }
}