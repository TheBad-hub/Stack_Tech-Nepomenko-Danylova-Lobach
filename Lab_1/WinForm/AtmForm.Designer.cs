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
        /// the contents of this method with the code editor./
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AtmForm));
            lblBalance = new Label();
            lblName = new Label();
            btnWithdraw = new Button();
            btnDeposit = new Button();
            btnTransfer = new Button();
            btnShowNearestATMs = new Button();
            btnTransactionHistory = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Location = new Point(438, 79);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(61, 15);
            lblBalance.TabIndex = 0;
            lblBalance.Text = "lblBalance";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = SystemColors.Control;
            lblName.Location = new Point(449, 49);
            lblName.Name = "lblName";
            lblName.Size = new Size(52, 15);
            lblName.TabIndex = 1;
            lblName.Text = "lblName";
            // 
            // btnWithdraw
            // 
            btnWithdraw.BackColor = SystemColors.Control;
            btnWithdraw.BackgroundImage = (Image)resources.GetObject("btnWithdraw.BackgroundImage");
            btnWithdraw.FlatAppearance.BorderSize = 0;
            btnWithdraw.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnWithdraw.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnWithdraw.FlatStyle = FlatStyle.Popup;
            btnWithdraw.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnWithdraw.ForeColor = SystemColors.ControlText;
            btnWithdraw.Location = new Point(14, 154);
            btnWithdraw.Margin = new Padding(3, 2, 3, 2);
            btnWithdraw.Name = "btnWithdraw";
            btnWithdraw.Size = new Size(140, 34);
            btnWithdraw.TabIndex = 2;
            btnWithdraw.Text = "Withdraw";
            btnWithdraw.UseVisualStyleBackColor = false;
            btnWithdraw.Click += btnWithdraw_Click;
            // 
            // btnDeposit
            // 
            btnDeposit.BackgroundImage = (Image)resources.GetObject("btnDeposit.BackgroundImage");
            btnDeposit.FlatAppearance.BorderSize = 0;
            btnDeposit.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnDeposit.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnDeposit.FlatStyle = FlatStyle.Popup;
            btnDeposit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDeposit.Location = new Point(14, 256);
            btnDeposit.Margin = new Padding(3, 2, 3, 2);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(140, 34);
            btnDeposit.TabIndex = 3;
            btnDeposit.Text = "Deposit";
            btnDeposit.UseVisualStyleBackColor = true;
            btnDeposit.Click += btnDeposit_Click;
            // 
            // btnTransfer
            // 
            btnTransfer.BackgroundImage = (Image)resources.GetObject("btnTransfer.BackgroundImage");
            btnTransfer.FlatAppearance.BorderSize = 0;
            btnTransfer.FlatStyle = FlatStyle.Popup;
            btnTransfer.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTransfer.ImageAlign = ContentAlignment.MiddleLeft;
            btnTransfer.Location = new Point(14, 358);
            btnTransfer.Margin = new Padding(3, 2, 3, 2);
            btnTransfer.Name = "btnTransfer";
            btnTransfer.Size = new Size(140, 34);
            btnTransfer.TabIndex = 4;
            btnTransfer.Text = "Transfer";
            btnTransfer.UseVisualStyleBackColor = true;
            btnTransfer.Click += btnTransfer_Click;
            // 
            // btnShowNearestATMs
            // 
            btnShowNearestATMs.BackgroundImage = (Image)resources.GetObject("btnShowNearestATMs.BackgroundImage");
            btnShowNearestATMs.FlatAppearance.BorderSize = 0;
            btnShowNearestATMs.FlatStyle = FlatStyle.Popup;
            btnShowNearestATMs.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnShowNearestATMs.Location = new Point(790, 154);
            btnShowNearestATMs.Margin = new Padding(3, 2, 3, 2);
            btnShowNearestATMs.Name = "btnShowNearestATMs";
            btnShowNearestATMs.Size = new Size(140, 34);
            btnShowNearestATMs.TabIndex = 5;
            btnShowNearestATMs.Text = " ATMs Near ";
            btnShowNearestATMs.UseVisualStyleBackColor = true;
            btnShowNearestATMs.Click += BtnShowNearestATMs_Click;
            // 
            // btnTransactionHistory
            // 
            btnTransactionHistory.BackgroundImage = (Image)resources.GetObject("btnTransactionHistory.BackgroundImage");
            btnTransactionHistory.FlatAppearance.BorderSize = 0;
            btnTransactionHistory.FlatStyle = FlatStyle.Popup;
            btnTransactionHistory.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTransactionHistory.Location = new Point(790, 256);
            btnTransactionHistory.Margin = new Padding(3, 2, 3, 2);
            btnTransactionHistory.Name = "btnTransactionHistory";
            btnTransactionHistory.Size = new Size(140, 34);
            btnTransactionHistory.TabIndex = 6;
            btnTransactionHistory.Text = "History";
            btnTransactionHistory.UseVisualStyleBackColor = true;
            btnTransactionHistory.Click += BtnTransactionHistory_Click;
            // 
            // btnExit
            // 
            btnExit.BackgroundImage = (Image)resources.GetObject("btnExit.BackgroundImage");
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnExit.Location = new Point(790, 358);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(140, 34);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // AtmForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(940, 463);
            Controls.Add(btnExit);
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
            Load += AtmForm_Load;
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
        private Button btnExit;
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm(new BankInitializer(this.bank, this.atm, accounts));
            loginForm.Show();
        }
    }
}