using System.ComponentModel;
using System.Security.Cryptography;
using System.Text;

public class Encryptor
{
    private bool paused = false;
    private readonly object pauseLock = new object();

    public void Pause()
    {
        paused = true;
    }

    public void Resume()
    {
        lock (pauseLock)
        {
            paused = false;
            Monitor.Pulse(pauseLock); // Продовжуємо роботу
        }
    }

    private void CheckPause()
    {
        lock (pauseLock)
        {
            while (paused)
            {
                Monitor.Wait(pauseLock); // Зупиняємо процес шифрування, поки активна пауза
            }
        }
    }

    // Метод для шифрования файла
    public void EncryptFile(string inputFilePath, string outputFilePath, string key, BackgroundWorker worker)
    {
        byte[] keyBytes = Encoding.UTF8.GetBytes(key.PadRight(32).Substring(0, 32)); // Генерация ключа
        using (FileStream inputStream = new FileStream(inputFilePath, FileMode.Open))
        using (FileStream outputStream = new FileStream(outputFilePath, FileMode.Create))
        using (Aes aes = Aes.Create())
        {
            aes.Key = keyBytes;
            aes.GenerateIV(); // Генерация вектора инициализации
            outputStream.Write(aes.IV, 0, aes.IV.Length); // Запись IV в начало выходного файла

            using (CryptoStream cryptoStream = new CryptoStream(outputStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
            {
                byte[] buffer = new byte[4096]; // Размер блока
                long totalBytesRead = 0;
                long fileLength = inputStream.Length;

                int bytesRead;
                while ((bytesRead = inputStream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    CheckPause(); // Перевірка паузи перед шифруванням блоку
                    cryptoStream.Write(buffer, 0, bytesRead); // Шифрование блока
                    totalBytesRead += bytesRead;

                    // Обновляем прогресс
                    int progressPercentage = (int)((double)totalBytesRead / fileLength * 100);
                    worker.ReportProgress(progressPercentage);

                    if (worker.CancellationPending)
                    {
                        break; // Прерываем операцию
                    }
                }
                worker.ReportProgress(100);
            }
        }
    }

    // Метод для дешифрования файла
    public void DecryptFile(string inputFilePath, string outputFilePath, string key, BackgroundWorker worker)
    {
        byte[] keyBytes = Encoding.UTF8.GetBytes(key.PadRight(32).Substring(0, 32)); // Генерация ключа
        using (FileStream inputStream = new FileStream(inputFilePath, FileMode.Open))
        using (FileStream outputStream = new FileStream(outputFilePath, FileMode.Create))
        using (Aes aes = Aes.Create())
        {
            byte[] iv = new byte[16]; // IV размер 16 байт
            inputStream.Read(iv, 0, iv.Length); // Чтение IV из входного файла
            aes.Key = keyBytes;
            aes.IV = iv;

            using (CryptoStream cryptoStream = new CryptoStream(inputStream, aes.CreateDecryptor(), CryptoStreamMode.Read))
            {
                byte[] buffer = new byte[4096]; // Размер блока
                long totalBytesRead = 0;
                long fileLength = inputStream.Length;

                int bytesRead;
                while ((bytesRead = cryptoStream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    CheckPause(); // Перевірка паузи перед дешифруванням блоку
                    outputStream.Write(buffer, 0, bytesRead); // Дешифрование блока
                    totalBytesRead += bytesRead;

                    // Обновляем прогресс
                    int progressPercentage = (int)((double)totalBytesRead / fileLength * 100);
                    worker.ReportProgress(progressPercentage);

                    if (worker.CancellationPending)
                    {
                        break; // Прерываем операцію
                    }
                }
                worker.ReportProgress(100);
            }
        }
    }
}
