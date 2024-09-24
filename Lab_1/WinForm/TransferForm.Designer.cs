namespace WinForm
{
    partial class TransferForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransferForm));
            btnConfirmTransfer = new Button();
            txtTargetCardNumber = new TextBox();
            txtTransferAmount = new TextBox();
            SuspendLayout();
            // 
            // btnConfirmTransfer
            // 
            btnConfirmTransfer.BackgroundImage = (Image)resources.GetObject("btnConfirmTransfer.BackgroundImage");
            btnConfirmTransfer.FlatStyle = FlatStyle.Popup;
            btnConfirmTransfer.Location = new Point(315, 247);
            btnConfirmTransfer.Margin = new Padding(3, 2, 3, 2);
            btnConfirmTransfer.Name = "btnConfirmTransfer";
            btnConfirmTransfer.Size = new Size(82, 22);
            btnConfirmTransfer.TabIndex = 0;
            btnConfirmTransfer.Text = "Confirm";
            btnConfirmTransfer.UseVisualStyleBackColor = true;
            btnConfirmTransfer.Click += btnConfirmTransfer_Click;
            // 
            // txtTargetCardNumber
            // 
            txtTargetCardNumber.Location = new Point(301, 103);
            txtTargetCardNumber.Margin = new Padding(3, 2, 3, 2);
            txtTargetCardNumber.Name = "txtTargetCardNumber";
            txtTargetCardNumber.Size = new Size(110, 23);
            txtTargetCardNumber.TabIndex = 1;
            // 
            // txtTransferAmount
            // 
            txtTransferAmount.Location = new Point(301, 179);
            txtTransferAmount.Margin = new Padding(3, 2, 3, 2);
            txtTransferAmount.Name = "txtTransferAmount";
            txtTransferAmount.Size = new Size(110, 23);
            txtTransferAmount.TabIndex = 2;
            // 
            // TransferForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(700, 338);
            Controls.Add(txtTransferAmount);
            Controls.Add(txtTargetCardNumber);
            Controls.Add(btnConfirmTransfer);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TransferForm";
            Text = "TransferForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private void btnConfirmTransfer_Click(object sender, EventArgs e)
        {
            if (accounts == null)
            {
                MessageBox.Show("Accounts data is not available. Please try again.");
                return;
            }

            string targetCardNumber = txtTargetCardNumber.Text.Trim();
            decimal amount;

            // Check if the target card number is the same as the current account
            if (targetCardNumber == currentAccount.CardNumber)
            {
                MessageBox.Show("You cannot transfer money to your own card.");
                return;
            }

            // Check if the target account exists
            if (!accounts.ContainsKey(targetCardNumber))
            {
                MessageBox.Show("Card with this number was not found.");
                return;
            }

            var targetAccount = accounts[targetCardNumber];

            // Attempt to parse the transfer amount
            if (!decimal.TryParse(txtTransferAmount.Text.Trim(), out amount) || amount <= 0)
            {
                MessageBox.Show("Invalid amount. Please enter a positive number.");
                return;
            }

            try
            {
                // Attempt to transfer money
                currentAccount.TransferMoney(targetAccount, amount);
                MessageBox.Show($"Successfully transferred {amount:C} to card {targetCardNumber}. Your balance is: {currentAccount.Balance:C}");
                this.Close();
            }
            catch (InvalidOperationException ex)
            {
                // Handle specific exceptions during transfer
                MessageBox.Show($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Handle any other unforeseen exceptions
                MessageBox.Show($"An unexpected error occurred: {ex.Message}");
            }
        }
        private Button btnConfirmTransfer;
        private TextBox txtTargetCardNumber;
        private TextBox txtTransferAmount;
    }
}