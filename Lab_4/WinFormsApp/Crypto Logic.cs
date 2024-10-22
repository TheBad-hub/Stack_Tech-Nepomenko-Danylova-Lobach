using System.ComponentModel;
using System.Security.Cryptography;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
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
                timer.Stop();
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
                btnCancel_Click(sender, e);
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
    }
}