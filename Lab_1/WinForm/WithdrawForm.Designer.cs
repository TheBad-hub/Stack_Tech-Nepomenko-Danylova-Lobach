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
            txtWithdrawAmount = new TextBox();
            btnConfirmWithdraw = new Button();
            SuspendLayout();
            // 
            // txtWithdrawAmount
            // 
            txtWithdrawAmount.Location = new Point(138, 110);
            txtWithdrawAmount.Name = "txtWithdrawAmount";
            txtWithdrawAmount.Size = new Size(125, 27);
            txtWithdrawAmount.TabIndex = 0;
            txtWithdrawAmount.Text = "txtWithdrawAmount";
            // 
            // btnConfirmWithdraw
            // 
            btnConfirmWithdraw.Location = new Point(139, 182);
            btnConfirmWithdraw.Name = "btnConfirmWithdraw";
            btnConfirmWithdraw.Size = new Size(94, 29);
            btnConfirmWithdraw.TabIndex = 1;
            btnConfirmWithdraw.Text = "btnConfirmWithdraw";
            btnConfirmWithdraw.UseVisualStyleBackColor = true;
            btnConfirmWithdraw.Click += btnConfirmWithdraw_Click;
            // 
            // WithdrawForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnConfirmWithdraw);
            Controls.Add(txtWithdrawAmount);
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
                if (currentAccount.Balance >= amount)
                {
                    currentAccount.Withdraw(amount);
                    currentAccount.AddTransaction($"Снято {amount:C}");
                    MessageBox.Show($"Ви зняли {amount:C}. Ваш баланс: {currentAccount.Balance:C}");
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

        private TextBox txtWithdrawAmount;
        private Button btnConfirmWithdraw;
    }
}