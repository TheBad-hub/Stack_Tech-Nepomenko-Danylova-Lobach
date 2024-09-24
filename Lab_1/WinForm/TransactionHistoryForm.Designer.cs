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
            cmbFilter = new ComboBox();
            lstTransactions = new ListBox();
            SuspendLayout();
            // 
            // cmbFilter
            // 
            cmbFilter.FormattingEnabled = true;
            cmbFilter.Location = new Point(213, 300);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Size = new Size(151, 28);
            cmbFilter.TabIndex = 0;
            // 
            // lstTransactions
            // 
            lstTransactions.FormattingEnabled = true;
            lstTransactions.Location = new Point(40, 26);
            lstTransactions.Name = "lstTransactions";
            lstTransactions.Size = new Size(483, 104);
            lstTransactions.TabIndex = 1;
            // 
            // TransactionHistoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstTransactions);
            Controls.Add(cmbFilter);
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