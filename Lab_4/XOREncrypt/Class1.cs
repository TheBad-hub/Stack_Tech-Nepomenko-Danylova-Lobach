using System.ComponentModel;
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
            Monitor.Pulse(pauseLock); // Resume the operation
        }
    }

    private void CheckPause()
    {
        lock (pauseLock)
        {
            while (paused)
            {
                Monitor.Wait(pauseLock); // Pause encryption/decryption process
            }
        }
    }

    // Method for encrypting a file using XOR
    public void EncryptFile(string inputFilePath, string outputFilePath, string key, BackgroundWorker worker)
    {
        byte[] keyBytes = Encoding.UTF8.GetBytes(key);
        int keyLength = keyBytes.Length;

        using (FileStream inputStream = new FileStream(inputFilePath, FileMode.Open))
        using (FileStream outputStream = new FileStream(outputFilePath, FileMode.Create))
        {
            byte[] buffer = new byte[4096]; // Block size
            long totalBytesRead = 0;
            long fileLength = inputStream.Length;

            int bytesRead;
            while ((bytesRead = inputStream.Read(buffer, 0, buffer.Length)) > 0)
            {
                CheckPause(); // Check pause before processing each block

                for (int i = 0; i < bytesRead; i++)
                {
                    buffer[i] ^= keyBytes[i % keyLength]; // XOR encryption
                }

                outputStream.Write(buffer, 0, bytesRead); // Write the encrypted block
                totalBytesRead += bytesRead;

                // Update progress
                int progressPercentage = (int)((double)totalBytesRead / fileLength * 100);
                worker.ReportProgress(progressPercentage);

                if (worker.CancellationPending)
                {
                    break; // Stop the operation if cancellation is requested
                }
            }

            worker.ReportProgress(100);
        }
    }

    // Method for decrypting a file using XOR
    public void DecryptFile(string inputFilePath, string outputFilePath, string key, BackgroundWorker worker)
    {
        byte[] keyBytes = Encoding.UTF8.GetBytes(key);
        int keyLength = keyBytes.Length;

        using (FileStream inputStream = new FileStream(inputFilePath, FileMode.Open))
        using (FileStream outputStream = new FileStream(outputFilePath, FileMode.Create))
        {
            byte[] buffer = new byte[4096]; // Block size
            long totalBytesRead = 0;
            long fileLength = inputStream.Length;

            int bytesRead;
            while ((bytesRead = inputStream.Read(buffer, 0, buffer.Length)) > 0)
            {
                CheckPause(); // Check pause before processing each block

                for (int i = 0; i < bytesRead; i++)
                {
                    buffer[i] ^= keyBytes[i % keyLength]; // XOR decryption
                }

                outputStream.Write(buffer, 0, bytesRead); // Write the decrypted block
                totalBytesRead += bytesRead;

                // Update progress
                int progressPercentage = (int)((double)totalBytesRead / fileLength * 100);
                worker.ReportProgress(progressPercentage);

                if (worker.CancellationPending)
                {
                    break; // Stop the operation if cancellation is requested
                }
            }

            worker.ReportProgress(100);
        }
    }
}