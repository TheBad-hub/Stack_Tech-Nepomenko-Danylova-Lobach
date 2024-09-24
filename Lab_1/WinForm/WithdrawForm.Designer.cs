namespace WinForm
{
    partial class WithdrawForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WithdrawForm));
            txtWithdrawAmount = new TextBox();
            btnConfirmWithdraw = new Button();
            SuspendLayout();
            // 
            // txtWithdrawAmount
            // 
            txtWithdrawAmount.Location = new Point(308, 112);
            txtWithdrawAmount.Margin = new Padding(3, 2, 3, 2);
            txtWithdrawAmount.Name = "txtWithdrawAmount";
            txtWithdrawAmount.Size = new Size(110, 23);
            txtWithdrawAmount.TabIndex = 0;
            // 
            // btnConfirmWithdraw
            // 
            btnConfirmWithdraw.BackgroundImage = (Image)resources.GetObject("btnConfirmWithdraw.BackgroundImage");
            btnConfirmWithdraw.FlatAppearance.BorderSize = 0;
            btnConfirmWithdraw.FlatStyle = FlatStyle.Popup;
            btnConfirmWithdraw.Location = new Point(317, 208);
            btnConfirmWithdraw.Margin = new Padding(3, 2, 3, 2);
            btnConfirmWithdraw.Name = "btnConfirmWithdraw";
            btnConfirmWithdraw.Size = new Size(82, 22);
            btnConfirmWithdraw.TabIndex = 1;
            btnConfirmWithdraw.Text = "Confirm";
            btnConfirmWithdraw.UseVisualStyleBackColor = true;
            btnConfirmWithdraw.Click += btnConfirmWithdraw_Click;
            // 
            // WithdrawForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(700, 338);
            Controls.Add(btnConfirmWithdraw);
            Controls.Add(txtWithdrawAmount);
            Margin = new Padding(3, 2, 3, 2);
            Name = "WithdrawForm";
            Text = "WithdrawForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private void btnConfirmWithdraw_Click(object sender, EventArgs e)
        {
            decimal amount;
            if (decimal.TryParse(txtWithdrawAmount.Text, out amount))
            {
                if (amount > 0)
                {
                    if (currentAccount.Balance >= amount)
                    {
                        currentAccount.Withdraw(amount);
                        MessageBox.Show($"You have withdrawn {amount:C}. Your balance is: {currentAccount.Balance:C}");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Insufficient funds in your account.");
                    }
                }
                else
                {
                    MessageBox.Show("Withdrawal amount must be a positive number.");
                }
            }
            else
            {
                MessageBox.Show("Invalid amount entered.");
            }
        }

        private TextBox txtWithdrawAmount;
        private Button btnConfirmWithdraw;
    }
}