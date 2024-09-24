namespace WinForm
{
    partial class DepositForm
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
            btnConfirmDeposit = new Button();
            txtDepositAmount = new TextBox();
            SuspendLayout();
            // 
            // btnConfirmDeposit
            // 
            btnConfirmDeposit.Location = new Point(130, 256);
            btnConfirmDeposit.Name = "btnConfirmDeposit";
            btnConfirmDeposit.Size = new Size(94, 29);
            btnConfirmDeposit.TabIndex = 0;
            btnConfirmDeposit.Text = "btnConfirmDeposit";
            btnConfirmDeposit.UseVisualStyleBackColor = true;
            btnConfirmDeposit.Click += btnConfirmDeposit_Click;
            // 
            // txtDepositAmount
            // 
            txtDepositAmount.Location = new Point(130, 100);
            txtDepositAmount.Name = "txtDepositAmount";
            txtDepositAmount.Size = new Size(125, 27);
            txtDepositAmount.TabIndex = 1;
            txtDepositAmount.Text = "txtDepositAmount";
            // 
            // DepositForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtDepositAmount);
            Controls.Add(btnConfirmDeposit);
            Name = "DepositForm";
            Text = "DepositForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private void btnConfirmDeposit_Click(object sender, EventArgs e)
        {
            decimal amount;
            if (decimal.TryParse(txtDepositAmount.Text, out amount))
            {
                if (amount > 0)
                {
                    currentAccount.Deposit(amount);
                    MessageBox.Show($"You have deposited {amount:C}. Your balance is: {currentAccount.Balance:C}");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Deposit amount must be a positive number.");
                }
            }
            else
            {
                MessageBox.Show("Invalid amount entered.");
            }
        }

        private Button btnConfirmDeposit;
        private TextBox txtDepositAmount;
    }
}