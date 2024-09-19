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
            // 
            // btnTransfer
            // 
            btnTransfer.Location = new Point(43, 274);
            btnTransfer.Name = "btnTransfer";
            btnTransfer.Size = new Size(94, 29);
            btnTransfer.TabIndex = 4;
            btnTransfer.Text = "btnTransfer";
            btnTransfer.UseVisualStyleBackColor = true;
            // 
            // AtmForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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

    }
}