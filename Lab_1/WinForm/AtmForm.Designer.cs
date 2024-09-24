using AtmLibrary;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace WinForm
{
    partial class AtmForm
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
            lblBalance = new Label();
            lblName = new Label();
            btnWithdraw = new Button();
            btnDeposit = new Button();
            btnTransfer = new Button();
            btnShowNearestATMs = new Button();
            btnTransactionHistory = new Button();
            SuspendLayout();
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Location = new Point(244, 82);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(61, 15);
            lblBalance.TabIndex = 0;
            lblBalance.Text = "lblBalance";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(245, 50);
            lblName.Name = "lblName";
            lblName.Size = new Size(52, 15);
            lblName.TabIndex = 1;
            lblName.Text = "lblName";
            // 
            // btnWithdraw
            // 
            btnWithdraw.Location = new Point(38, 117);
            btnWithdraw.Margin = new Padding(3, 2, 3, 2);
            btnWithdraw.Name = "btnWithdraw";
            btnWithdraw.Size = new Size(82, 22);
            btnWithdraw.TabIndex = 2;
            btnWithdraw.Text = "btnWithdraw";
            btnWithdraw.UseVisualStyleBackColor = true;
            btnWithdraw.Click += btnWithdraw_Click;
            // 
            // btnDeposit
            // 
            btnDeposit.Location = new Point(38, 158);
            btnDeposit.Margin = new Padding(3, 2, 3, 2);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(82, 22);
            btnDeposit.TabIndex = 3;
            btnDeposit.Text = "btnDeposit";
            btnDeposit.UseVisualStyleBackColor = true;
            btnDeposit.Click += btnDeposit_Click;
            // 
            // btnTransfer
            // 
            btnTransfer.Location = new Point(38, 206);
            btnTransfer.Margin = new Padding(3, 2, 3, 2);
            btnTransfer.Name = "btnTransfer";
            btnTransfer.Size = new Size(82, 22);
            btnTransfer.TabIndex = 4;
            btnTransfer.Text = "btnTransfer";
            btnTransfer.UseVisualStyleBackColor = true;
            btnTransfer.Click += btnTransfer_Click;
            // 
            // btnShowNearestATMs
            // 
            btnShowNearestATMs.Location = new Point(388, 117);
            btnShowNearestATMs.Margin = new Padding(3, 2, 3, 2);
            btnShowNearestATMs.Name = "btnShowNearestATMs";
            btnShowNearestATMs.Size = new Size(82, 22);
            btnShowNearestATMs.TabIndex = 5;
            btnShowNearestATMs.Text = "btnShowNearestATMs";
            btnShowNearestATMs.UseVisualStyleBackColor = true;
            btnShowNearestATMs.Click += BtnShowNearestATMs_Click;
            // 
            // btnTransactionHistory
            // 
            btnTransactionHistory.Location = new Point(388, 158);
            btnTransactionHistory.Margin = new Padding(3, 2, 3, 2);
            btnTransactionHistory.Name = "btnTransactionHistory";
            btnTransactionHistory.Size = new Size(82, 22);
            btnTransactionHistory.TabIndex = 6;
            btnTransactionHistory.Text = "btnTransactionHistory";
            btnTransactionHistory.UseVisualStyleBackColor = true;
            btnTransactionHistory.Click += BtnTransactionHistory_Click;
            // 
            // AtmForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(btnTransactionHistory);
            Controls.Add(btnShowNearestATMs);
            Controls.Add(btnTransfer);
            Controls.Add(btnDeposit);
            Controls.Add(btnWithdraw);
            Controls.Add(lblName);
            Controls.Add(lblBalance);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AtmForm";
            Text = "AtmFormcs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBalance;
        private Label lblName;
        private Button btnWithdraw;
        private Button btnDeposit;
        private Button btnTransfer;

        private void UpdateNameInfo()
        {
            lblName.Text = $"Hello, {currentAccount.Owner}!";
        }

        private void UpdateBalanceInfo()
        {
            lblBalance.Text = $"Your balance: {currentAccount.Balance} uah";
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            WithdrawForm withdrawForm = new WithdrawForm(currentAccount);
            withdrawForm.ShowDialog();
            UpdateBalanceInfo();
        }
        private void btnDeposit_Click(object sender, EventArgs e)
        {
            DepositForm depositForm = new DepositForm(currentAccount);
            depositForm.ShowDialog();
            UpdateBalanceInfo();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            TransferForm transferForm = new TransferForm(currentAccount, accounts);
            transferForm.ShowDialog();
            UpdateBalanceInfo();
        }
        private void BtnShowNearestATMs_Click(object sender, EventArgs e)
        {
            if (bank != null && atm != null)
            {
                // Отримуємо найближчі банкомати 
                var nearestAtms = bank.GetNearestATMs(atm, 4);

                NearestAtmsForm nearestAtmsForm = new NearestAtmsForm(nearestAtms, atm);

                nearestAtmsForm.Show();
            }
            else
            {
                MessageBox.Show("Помилка: не знайдено банкомат або банк.");
            }
        }
        private void BtnTransactionHistory_Click(object sender, EventArgs e)
        {
            var transactionHistoryForm = new TransactionHistoryForm(currentAccount.GetTransactionHistory());
            transactionHistoryForm.Show();
        }

        private Button btnShowNearestATMs;
        private Button btnTransactionHistory;
    }
}