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
            txtFilePath.Location = new Point(30, 30);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.PlaceholderText = "Оберіть файл для шифрування/дешифрування";
            txtFilePath.Size = new Size(527, 23);
            txtFilePath.TabIndex = 0;
            // 
            // txtKey
            // 
            txtKey.Location = new Point(30, 70);
            txtKey.Name = "txtKey";
            txtKey.PlaceholderText = "Введіть ключ шифрування";
            txtKey.Size = new Size(527, 23);
            txtKey.TabIndex = 1;
            // 
            // btnChooseFile
            // 
            btnChooseFile.Location = new Point(587, 30);
            btnChooseFile.Name = "btnChooseFile";
            btnChooseFile.Size = new Size(120, 30);
            btnChooseFile.TabIndex = 2;
            btnChooseFile.Text = "Оберіть файл";
            btnChooseFile.UseVisualStyleBackColor = true;
            btnChooseFile.Click += btnChooseFile_Click;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(30, 150);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(120, 40);
            btnStart.TabIndex = 3;
            btnStart.Text = "Шифрувати";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(335, 150);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 40);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Скасувати";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(27, 335);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(497, 30);
            progressBar.TabIndex = 6;
            // 
            // lblProgress
            // 
            lblProgress.AutoSize = true;
            lblProgress.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblProgress.Location = new Point(539, 335);
            lblProgress.Name = "lblProgress";
            lblProgress.Size = new Size(38, 25);
            lblProgress.TabIndex = 7;
            lblProgress.Text = "0%";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { EncryptToolStripMenuItem, DecryptToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(887, 24);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // EncryptToolStripMenuItem
            // 
            EncryptToolStripMenuItem.Name = "EncryptToolStripMenuItem";
            EncryptToolStripMenuItem.Size = new Size(83, 20);
            EncryptToolStripMenuItem.Text = "Шифрувати";
            EncryptToolStripMenuItem.Click += EncryptToolStripMenuItem_Click;
            // 
            // DecryptToolStripMenuItem
            // 
            DecryptToolStripMenuItem.Name = "DecryptToolStripMenuItem";
            DecryptToolStripMenuItem.Size = new Size(97, 20);
            DecryptToolStripMenuItem.Text = "Дешифрувати";
            DecryptToolStripMenuItem.Click += DecryptToolStripMenuItem_Click;
            // 
            // btnPause
            // 
            btnPause.Location = new Point(190, 150);
            btnPause.Name = "btnPause";
            btnPause.Size = new Size(120, 40);
            btnPause.TabIndex = 9;
            btnPause.Text = "Пауза";
            btnPause.UseVisualStyleBackColor = true;
            btnPause.Click += btnPause_Click;
            // 
            // lblTimeElapsed
            // 
            lblTimeElapsed.Font = new Font("Segoe UI", 12F);
            lblTimeElapsed.Location = new Point(30, 300);
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
            cmbPriority.Location = new Point(30, 110);
            cmbPriority.Name = "cmbPriority";
            cmbPriority.Size = new Size(200, 23);
            cmbPriority.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(887, 405);
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
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Шифрувальник файлів";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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

        private void InitializeBackgroundWorker()
        {
            encryptor = new Encryptor();
            worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.WorkerSupportsCancellation = true;
            worker.DoWork += Worker_DoWork;
            worker.ProgressChanged += Worker_ProgressChanged;
            worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
        }
        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                if (worker.CancellationPending)
                {
                    e.Cancel = true; // Устанавливаем флаг отмены
                    return; // Прерываем выполнение
                }

                if (isEncrypting)
                {
                    encryptor.EncryptFile(inputFilePath, outputFilePath, encryptionKey, worker);
                }
                else
                {
                    encryptor.DecryptFile(inputFilePath, outputFilePath, encryptionKey, worker);
                }
            }
            catch (OperationCanceledException)
            {
                e.Cancel = true; // Устанавливаем флаг отмены
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("У вас нет разрешения на доступ к файлу.");
                e.Cancel = true;
            }
            catch (CryptographicException)
            {
                MessageBox.Show("Ключі не сходяться");
                e.Cancel = true;
                btnCancel_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
                e.Cancel = true;
            }
        }

        private void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
            lblProgress.Text = $"{e.ProgressPercentage}%";
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            timer.Stop(); // Останавливаем таймер

            if (e.Cancelled)
            {
                MessageBox.Show("Операція скасована. Файл видалено.");
            }
            else if (e.Error != null)
            {
                MessageBox.Show("Виникла помилка: " + e.Error.Message);
            }
            else
            {
                // Если операция завершена успешно
                TimeSpan timeTaken = DateTime.Now - startTime; // Вираховуємо час виконання
                lblTimeElapsed.Text = string.Format("{0:hh\\:mm\\:ss\\.fff}", timeTaken); // Відображаємо час

                FileInfo fileInfo = new FileInfo(outputFilePath);
                long fileSizeInBytes = fileInfo.Length;

                string message = $"Операція завершена.\n" +
                                 $"Файл: {Path.GetFileName(outputFilePath)}\n" +
                                 $"Розмір файла: {fileSizeInBytes / 1024.0:F2} КБ\n" +
                                 $"Час виконання: {timeTaken.TotalSeconds:F2} секунд.";

                MessageBox.Show(message);
            }
        }
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
        private void btnStart_Click(object sender, EventArgs e) { }
        private void btnCancel_Click(object sender, EventArgs e) { }
        private void EncryptToolStripMenuItem_Click(object sender, EventArgs e) { }
        private void DecryptToolStripMenuItem_Click(object sender, EventArgs e) { }
        private void btnPause_Click(object sender, EventArgs e) { }
    }
}
