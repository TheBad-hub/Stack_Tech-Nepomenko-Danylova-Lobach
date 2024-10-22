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
            txtFilePath.Location = new Point(27, 60);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.PlaceholderText = "Оберіть файл для шифрування/дешифрування";
            txtFilePath.Size = new Size(527, 23);
            txtFilePath.TabIndex = 0;
            // 
            // txtKey
            // 
            txtKey.Location = new Point(27, 102);
            txtKey.Name = "txtKey";
            txtKey.PlaceholderText = "Введіть ключ шифрування";
            txtKey.Size = new Size(527, 23);
            txtKey.TabIndex = 1;
            // 
            // btnChooseFile
            // 
            btnChooseFile.Location = new Point(626, 80);
            btnChooseFile.Name = "btnChooseFile";
            btnChooseFile.Size = new Size(120, 30);
            btnChooseFile.TabIndex = 2;
            btnChooseFile.Text = "Оберіть файл";
            btnChooseFile.UseVisualStyleBackColor = true;
            btnChooseFile.Click += btnChooseFile_Click;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(27, 189);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(120, 40);
            btnStart.TabIndex = 3;
            btnStart.Text = "Шифрувати";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(359, 189);
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
            lblProgress.BackColor = Color.Transparent;
            lblProgress.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblProgress.Location = new Point(539, 340);
            lblProgress.Name = "lblProgress";
            lblProgress.Size = new Size(38, 25);
            lblProgress.TabIndex = 7;
            lblProgress.Text = "0%";
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
            btnPause.Location = new Point(193, 189);
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
            cmbPriority.Location = new Point(27, 140);
            cmbPriority.Name = "cmbPriority";
            cmbPriority.Size = new Size(200, 23);
            cmbPriority.TabIndex = 1;
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
                btnCancel_Click(sender, e);
                e.Cancel = true;
                MessageBox.Show("Поганий ключ\n(Ключі не сходяться або інші проблеми).");
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
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!File.Exists(txtFilePath.Text) || string.IsNullOrWhiteSpace(txtKey.Text))
            {
                MessageBox.Show("Будь ласка, виберіть файл та введіть ключ.");
                return;
            }

            inputFilePath = txtFilePath.Text;

            if (isEncrypting)
            {
                // Додаем суффикс .enc при шифровании
                outputFilePath = inputFilePath + ".enc";
            }
            else
            {
                // При дешифровке сохраняем исходное расширение файла
                if (inputFilePath.EndsWith(".enc"))
                {
                    string originalExtension = Path.GetExtension(inputFilePath.Substring(0, inputFilePath.Length - 4)); // Извлекаем расширение
                    string fileNameWithoutEnc = Path.GetFileNameWithoutExtension(inputFilePath.Substring(0, inputFilePath.Length - 4)); // Имя файла без .enc
                    outputFilePath = fileNameWithoutEnc + originalExtension; // Восстанавливаем исходное имя с расширением
                }
                else
                {
                    MessageBox.Show("Некоректний файл для дешифрування.");
                    return;
                }
            }

            // Используем SaveFileDialog для выбора места сохранения
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "All files (*.*)|*.*"; // Фильтр для сохранения файла
                saveFileDialog.Title = isEncrypting ? "Збережіть зашифрований файл" : "Збережіть розшифрований файл";
                saveFileDialog.FileName = Path.GetFileName(outputFilePath); // Устанавливаем правильное имя файла

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    outputFilePath = saveFileDialog.FileName; // Получаем путь для сохранения
                }
                else
                {
                    MessageBox.Show("Операцію скасовано. Файл не було вибрано.");
                    return;
                }
            }

            // Отримуємо вибраний пріоритет
            string selectedPriority = cmbPriority.SelectedItem.ToString();

            ThreadPriority priority = ThreadPriority.Normal;

            switch (selectedPriority)
            {
                case "Низький":
                    priority = ThreadPriority.BelowNormal;
                    break;
                case "Середній":
                    priority = ThreadPriority.Normal;
                    break;
                case "Високий":
                    priority = ThreadPriority.AboveNormal;
                    break;
            }

            // Встановлюємо пріоритет фоновому робочому потоку
            Thread.CurrentThread.Priority = priority;

            encryptionKey = txtKey.Text;
            startTime = DateTime.Now; // Запоминаем начало
            timer.Start(); // Запускаем таймер
            worker.RunWorkerAsync(); // Запускаємо фоновий процес
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            isPaused = !isPaused; // Переключаем состояние
            btnPause.Text = isPaused ? "Продовжити" : "Пауза"; // Изменяем текст кнопки

            if (isPaused)
            {
                encryptor.Pause();
                timer.Stop(); // Зупиняємо таймер під час паузи
            }
            else
            {
                encryptor.Resume();
                timer.Start(); // Запускаємо таймер знову
            }
        }

        // Кнопка для скасування шифрування
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (worker.IsBusy)
            {
                worker.CancelAsync(); // Запросить отмену
            }

            // Ожидаем завершения потока
            while (worker.IsBusy)
            {
                Application.DoEvents(); // Обновляем интерфейс
                Thread.Sleep(100); // Небольшая задержка для уменьшения нагрузки
            }

            // Проверяем, был ли создан выходной файл
            if (File.Exists(outputFilePath))
            {
                try
                {
                    File.Delete(outputFilePath); // Удаляем выходной файл
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Не удалось удалить файл: {ex.Message}");
                    return; // Выход из метода, если удаление не удалось
                }
            }

            // Обнуляем прогресс-бар
            timer.Stop();
            progressBar.Value = 0;
            lblProgress.Text = "0%";

            // Обнуляем время
            lblTimeElapsed.Text = "00:00:00.000";
        }

        // Кнопка для вибору між шифруванням і дешифруванням
        private void toggleEncryptDecrypt(object sender, EventArgs e)
        {
            btnStart.Text = isEncrypting ? "Шифрувати" : "Дешифрувати";
        }
        private void EncryptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //BackgroundImage = WinFormsApp1.Properties.Resources.noisy_gradients; // Фон для шифрования
            isEncrypting = true;
            toggleEncryptDecrypt(sender, e);
        }

        private void DecryptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //BackgroundImage = WinFormsApp1.Properties.Resources.noisy_gradients_2; // Фон для дешифрования
            isEncrypting = false;
            toggleEncryptDecrypt(sender, e);
        }
    }
}
