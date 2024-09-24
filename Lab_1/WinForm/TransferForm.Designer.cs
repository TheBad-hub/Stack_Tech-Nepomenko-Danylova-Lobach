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
            btnConfirmTransfer = new Button();
            txtTargetCardNumber = new TextBox();
            txtTransferAmount = new TextBox();
            SuspendLayout();
            // 
            // btnConfirmTransfer
            // 
            btnConfirmTransfer.Location = new Point(112, 275);
            btnConfirmTransfer.Name = "btnConfirmTransfer";
            btnConfirmTransfer.Size = new Size(94, 29);
            btnConfirmTransfer.TabIndex = 0;
            btnConfirmTransfer.Text = "btnConfirmTransfer";
            btnConfirmTransfer.UseVisualStyleBackColor = true;
            btnConfirmTransfer.Click += btnConfirmTransfer_Click;
            // 
            // txtTargetCardNumber
            // 
            txtTargetCardNumber.Location = new Point(112, 65);
            txtTargetCardNumber.Name = "txtTargetCardNumber";
            txtTargetCardNumber.Size = new Size(125, 27);
            txtTargetCardNumber.TabIndex = 1;
            txtTargetCardNumber.Text = "txtTargetCardNumber";
            // 
            // txtTransferAmount
            // 
            txtTransferAmount.Location = new Point(114, 122);
            txtTransferAmount.Name = "txtTransferAmount";
            txtTransferAmount.Size = new Size(125, 27);
            txtTransferAmount.TabIndex = 2;
            txtTransferAmount.Text = "txtTransferAmount";
            // 
            // TransferForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtTransferAmount);
            Controls.Add(txtTargetCardNumber);
            Controls.Add(btnConfirmTransfer);
            Name = "TransferForm";
            Text = "TransferForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private void btnConfirmTransfer_Click(object sender, EventArgs e)
        {
            string targetCardNumber = txtTargetCardNumber.Text;
            decimal amount;
            
            if (targetCardNumber == currentAccount.CardNumber)
            {
                MessageBox.Show("Неможливо перерахувати кошти на ту саму картку.");
                return;
            }
            if (accounts.ContainsKey(targetCardNumber))
            {
                var targetAccount = accounts[targetCardNumber];

                if (decimal.TryParse(txtTransferAmount.Text, out amount))
                {
                    if (currentAccount.Balance >= amount)
                    {
                        currentAccount.Withdraw(amount);
                        targetAccount.Deposit(amount);

                        MessageBox.Show($"Ви перерахували {amount:C} на картку {targetCardNumber}. Ваш баланс: {currentAccount.Balance:C}");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Недостатньо коштів на рахунку.");
                    }
                }
                else
                {
                    MessageBox.Show("Некоректна сума.");
                }
            }
            else
            {
                MessageBox.Show("Картка з таким номером не знайдена.");
            }
        }

        private Button btnConfirmTransfer;
        private TextBox txtTargetCardNumber;
        private TextBox txtTransferAmount;
    }
}