using System.ComponentModel;
using System.Security.Cryptography;
using Timer = System.Windows.Forms.Timer;

namespace WinFormsApp
{
    partial class Form1
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
            components = new Container();
            txtFilePath = new TextBox();
            txtKey = new TextBox();
            btnChooseFile = new Button();
            btnStart = new Button();
            btnCancel = new Button();
            progressBar = new ProgressBar();
            lblProgress = new Label();
            menuStrip1 = new MenuStrip();
            EncryptToolStripMenuItem = new ToolStripMenuItem();
            DecryptToolStripMenuItem = new ToolStripMenuItem();
            btnPause = new Button();
            lblTimeElapsed = new Label();
            timer = new Timer(components);
            cmbPriority = new ComboBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtFilePath
            // 
            txtFilePath.Location = new Point(66, 64);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.PlaceholderText = "Оберіть файл для шифрування/дешифрування";
            txtFilePath.Size = new Size(527, 23);
            txtFilePath.TabIndex = 0;
            // 
            // txtKey
            // 
            txtKey.Location = new Point(66, 109);
            txtKey.Name = "txtKey";
            txtKey.PlaceholderText = "Введіть ключ шифрування";
            txtKey.Size = new Size(527, 23);
            txtKey.TabIndex = 1;
            // 
            // btnChooseFile
            // 
            btnChooseFile.Location = new Point(66, 174);
            btnChooseFile.Name = "btnChooseFile";
            btnChooseFile.Size = new Size(120, 30);
            btnChooseFile.TabIndex = 2;
            btnChooseFile.Text = "Оберіть файл";
            btnChooseFile.UseVisualStyleBackColor = true;
            btnChooseFile.Click += btnChooseFile_Click;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(70, 252);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(120, 40);
            btnStart.TabIndex = 3;
            btnStart.Text = "Шифрувати";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(459, 252);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 40);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Скасувати";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(66, 371);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(527, 30);
            progressBar.TabIndex = 6;
            // 
            // lblProgress
            // 
            lblProgress.AutoSize = true;
            lblProgress.BackColor = Color.Transparent;
            lblProgress.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblProgress.Location = new Point(541, 329);
            lblProgress.Name = "lblProgress";
            lblProgress.Size = new Size(38, 25);
            lblProgress.TabIndex = 7;
            lblProgress.Text = "0%";
            lblProgress.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { EncryptToolStripMenuItem, DecryptToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(853, 24);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // EncryptToolStripMenuItem
            // 
            EncryptToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight;
            EncryptToolStripMenuItem.Name = "EncryptToolStripMenuItem";
            EncryptToolStripMenuItem.Size = new Size(83, 20);
            EncryptToolStripMenuItem.Text = "Шифрувати";
            EncryptToolStripMenuItem.Click += EncryptToolStripMenuItem_Click;
            // 
            // DecryptToolStripMenuItem
            // 
            DecryptToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight;
            DecryptToolStripMenuItem.Name = "DecryptToolStripMenuItem";
            DecryptToolStripMenuItem.Size = new Size(97, 20);
            DecryptToolStripMenuItem.Text = "Дешифрувати";
            DecryptToolStripMenuItem.Click += DecryptToolStripMenuItem_Click;
            // 
            // btnPause
            // 
            btnPause.BackColor = Color.Transparent;
            btnPause.Location = new Point(265, 252);
            btnPause.Name = "btnPause";
            btnPause.Size = new Size(120, 40);
            btnPause.TabIndex = 9;
            btnPause.Text = "Пауза";
            btnPause.UseVisualStyleBackColor = false;
            btnPause.Click += btnPause_Click;
            // 
            // lblTimeElapsed
            // 
            lblTimeElapsed.BackColor = Color.Transparent;
            lblTimeElapsed.Font = new Font("Segoe UI", 12F);
            lblTimeElapsed.Location = new Point(66, 332);
            lblTimeElapsed.Name = "lblTimeElapsed";
            lblTimeElapsed.Size = new Size(200, 30);
            lblTimeElapsed.TabIndex = 0;
            lblTimeElapsed.Text = "00:00:00.000";
            // 
            // timer
            // 
            timer.Interval = 1;
            timer.Tick += Timer_Tick;
            // 
            // cmbPriority
            // 
            cmbPriority.Cursor = Cursors.Hand;
            cmbPriority.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPriority.Items.AddRange(new object[] { "Низький", "Середній", "Високий" });
            cmbPriority.Location = new Point(393, 178);
            cmbPriority.Name = "cmbPriority";
            cmbPriority.Size = new Size(200, 23);
            cmbPriority.TabIndex = 1;
            cmbPriority.SelectedIndex = 1;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = Properties.Resources.Lab_4BC_1;
            ClientSize = new Size(853, 425);
            Controls.Add(lblTimeElapsed);
            Controls.Add(cmbPriority);
            Controls.Add(btnPause);
            Controls.Add(lblProgress);
            Controls.Add(progressBar);
            Controls.Add(btnCancel);
            Controls.Add(btnStart);
            Controls.Add(btnChooseFile);
            Controls.Add(txtKey);
            Controls.Add(txtFilePath);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Шифрувальник файлів";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTimeElapsed;
        private TextBox txtFilePath;
        private TextBox txtKey;
        private Button btnChooseFile;
        private Button btnStart;
        private Button btnCancel;
        private ProgressBar progressBar;
        private Label lblProgress;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem EncryptToolStripMenuItem;
        private ToolStripMenuItem DecryptToolStripMenuItem;
        private Button btnPause;
        private ComboBox cmbPriority;

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    inputFilePath = openFileDialog.FileName;
                    txtFilePath.Text = inputFilePath;
                }
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsed = DateTime.Now - startTime;
            lblTimeElapsed.Text = string.Format("{0:hh\\:mm\\:ss\\.fff}", elapsed);
        }

        private void EncryptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.Lab_4BC_1;
            isEncrypting = true;
            toggleEncryptDecrypt(sender, e);
        }

        private void DecryptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.Lab_4BC_2;
            isEncrypting = false;
            toggleEncryptDecrypt(sender, e);
        }
        // Кнопка для вибору між шифруванням і дешифруванням
        private void toggleEncryptDecrypt(object sender, EventArgs e)
        {
            btnStart.Text = isEncrypting ? "Шифрувати" : "Дешифрувати";
        }
    }
}
