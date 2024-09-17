namespace WinForm
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtCardNumber = new TextBox();
            txtPinCode = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // txtCardNumber
            // 
            txtCardNumber.Location = new Point(128, 171);
            txtCardNumber.Name = "txtCardNumber";
            txtCardNumber.Size = new Size(125, 27);
            txtCardNumber.TabIndex = 0;
            txtCardNumber.Text = "txtCardNumber";
            // 
            // txtPinCode
            // 
            txtPinCode.Location = new Point(128, 222);
            txtPinCode.Name = "txtPinCode";
            txtPinCode.Size = new Size(125, 27);
            txtPinCode.TabIndex = 1;
            txtPinCode.Text = "txtPinCode";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(128, 267);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "btnLogin";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogin);
            Controls.Add(txtPinCode);
            Controls.Add(txtCardNumber);
            Name = "LoginForm";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCardNumber;
        private TextBox txtPinCode;
        private Button btnLogin;


        // Обробник для кнопки автентифікації
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string cardNumber = txtCardNumber.Text;
            string pinCode = txtPinCode.Text;
            ///
            /// TODO: Перевірка пін-коду
            ///

            if (accounts.ContainsKey(cardNumber))
            {
                currentAccount = accounts[cardNumber];

                MessageBox.Show("Успішна автентифікація");

                // Відкриваємо основну форму ATM та передаємо туди дані
                AtmForm atmForm = new AtmForm(currentAccount, atm);
                atmForm.Show();
                this.Hide(); 
            }
            else
            {
                MessageBox.Show("Невірний номер картки або пін-код");
            }
        }
    }
}
