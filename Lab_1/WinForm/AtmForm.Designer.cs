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
            lblBalance.Location = new Point(279, 110);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(78, 20);
            lblBalance.TabIndex = 0;
            lblBalance.Text = "lblBalance";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(280, 66);
            lblName.Name = "lblName";
            lblName.Size = new Size(66, 20);
            lblName.TabIndex = 1;
            lblName.Text = "lblName";
            // 
            // btnWithdraw
            // 
            btnWithdraw.Location = new Point(43, 156);
            btnWithdraw.Name = "btnWithdraw";
            btnWithdraw.Size = new Size(94, 29);
            btnWithdraw.TabIndex = 2;
            btnWithdraw.Text = "btnWithdraw";
            btnWithdraw.UseVisualStyleBackColor = true;
            btnWithdraw.Click += btnWithdraw_Click;
            // 
            // btnDeposit
            // 
            btnDeposit.Location = new Point(43, 211);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(94, 29);
            btnDeposit.TabIndex = 3;
            btnDeposit.Text = "btnDeposit";
            btnDeposit.UseVisualStyleBackColor = true;
            btnDeposit.Click += btnDeposit_Click;
            // 
            // btnTransfer
            // 
            btnTransfer.Location = new Point(43, 274);
            btnTransfer.Name = "btnTransfer";
            btnTransfer.Size = new Size(94, 29);
            btnTransfer.TabIndex = 4;
            btnTransfer.Text = "btnTransfer";
            btnTransfer.UseVisualStyleBackColor = true;
            btnTransfer.Click += btnTransfer_Click;
            // 
            // btnShowNearestATMs
            // 
            btnShowNearestATMs.Location = new Point(444, 162);
            btnShowNearestATMs.Name = "btnShowNearestATMs";
            btnShowNearestATMs.Size = new Size(94, 29);
            btnShowNearestATMs.TabIndex = 5;
            btnShowNearestATMs.Text = "btnShowNearestATMs";
            btnShowNearestATMs.UseVisualStyleBackColor = true;
            btnShowNearestATMs.Click += BtnShowNearestATMs_Click;
            // 
            // btnTransactionHistory
            // 
            btnTransactionHistory.Location = new Point(452, 248);
            btnTransactionHistory.Name = "btnTransactionHistory";
            btnTransactionHistory.Size = new Size(94, 29);
            btnTransactionHistory.TabIndex = 6;
            btnTransactionHistory.Text = "btnTransactionHistory";
            btnTransactionHistory.UseVisualStyleBackColor = true;
            btnTransactionHistory.Click += BtnTransactionHistory_Click;
            // 
            // AtmForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTransactionHistory);
            Controls.Add(btnShowNearestATMs);
            Controls.Add(btnTransfer);
            Controls.Add(btnDeposit);
            Controls.Add(btnWithdraw);
            Controls.Add(lblName);
            Controls.Add(lblBalance);
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