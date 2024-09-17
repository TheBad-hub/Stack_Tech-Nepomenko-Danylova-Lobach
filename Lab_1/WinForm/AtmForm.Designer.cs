﻿namespace WinForm
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
            // AtmForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblName);
            Controls.Add(lblBalance);
            Name = "AtmForm";
            Text = "AtmFormcs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBalance;

        private void UpdateAccountInfo()
        {
            lblName.Text = $"Привіт, {currentAccount.OwnerName}!";
            lblBalance.Text = $"Баланс: {currentAccount.Balance} грн";
        }

        private Label lblName;
    }
}