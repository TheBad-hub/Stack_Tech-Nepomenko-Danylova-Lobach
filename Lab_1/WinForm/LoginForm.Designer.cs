using AtmLibrary;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            txtCardNumber = new TextBox();
            txtPinCode = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // txtCardNumber
            // 
            txtCardNumber.Location = new Point(303, 103);
            txtCardNumber.Margin = new Padding(3, 2, 3, 2);
            txtCardNumber.Name = "txtCardNumber";
            txtCardNumber.Size = new Size(110, 23);
            txtCardNumber.TabIndex = 0;
            // 
            // txtPinCode
            // 
            txtPinCode.Location = new Point(303, 179);
            txtPinCode.Margin = new Padding(3, 2, 3, 2);
            txtPinCode.Name = "txtPinCode";
            txtPinCode.Size = new Size(110, 23);
            txtPinCode.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.BackgroundImage = (Image)resources.GetObject("btnLogin.BackgroundImage");
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Location = new Point(317, 247);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(82, 26);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // LoginForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(700, 338);
            Controls.Add(btnLogin);
            Controls.Add(txtPinCode);
            Controls.Add(txtCardNumber);
            Margin = new Padding(3, 2, 3, 2);
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

            if (accounts.ContainsKey(cardNumber))
            {
                currentAccount = accounts[cardNumber];

                if (currentAccount.ValidatePin(pinCode))
                {
                    MessageBox.Show("Успішна автентифікація");

                    // Открываем основную форму ATM и передаем данные
                    AtmForm atmForm = new AtmForm(initializer,currentAccount);
                    atmForm.Show();
                    this.Hide();
                }
                else
                {   
                    MessageBox.Show("Невірний пін-код");
                }
            }
            else
            {
                MessageBox.Show("Невірний номер картки");
            }
        }
    }
}

