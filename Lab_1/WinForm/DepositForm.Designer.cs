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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepositForm));
            btnConfirmDeposit = new Button();
            txtDepositAmount = new TextBox();
            SuspendLayout();
            // 
            // btnConfirmDeposit
            // 
            btnConfirmDeposit.BackgroundImage = (Image)resources.GetObject("btnConfirmDeposit.BackgroundImage");
            btnConfirmDeposit.FlatStyle = FlatStyle.Popup;
            btnConfirmDeposit.Location = new Point(317, 208);
            btnConfirmDeposit.Margin = new Padding(3, 2, 3, 2);
            btnConfirmDeposit.Name = "btnConfirmDeposit";
            btnConfirmDeposit.Size = new Size(82, 22);
            btnConfirmDeposit.TabIndex = 0;
            btnConfirmDeposit.Text = "Confirm";
            btnConfirmDeposit.UseVisualStyleBackColor = true;
            btnConfirmDeposit.Click += btnConfirmDeposit_Click;
            // 
            // txtDepositAmount
            // 
            txtDepositAmount.Location = new Point(308, 112);
            txtDepositAmount.Margin = new Padding(3, 2, 3, 2);
            txtDepositAmount.Name = "txtDepositAmount";
            txtDepositAmount.Size = new Size(110, 23);
            txtDepositAmount.TabIndex = 1;
            // 
            // DepositForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(700, 338);
            Controls.Add(txtDepositAmount);
            Controls.Add(btnConfirmDeposit);
            Margin = new Padding(3, 2, 3, 2);
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