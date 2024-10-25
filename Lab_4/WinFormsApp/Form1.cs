using System.ComponentModel;
using Timer = System.Windows.Forms.Timer;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        private string inputFilePath;
        private string outputFilePath;
        private string encryptionKey;
        private bool isEncrypting = true; // За замовчуванням шифрування
        private Encryptor encryptor;
        private DateTime startTime;
        private BackgroundWorker worker;
        private bool isPaused = false;
        private Timer timer;

        public Form1()
        {
            InitializeComponent();
            InitializeBackgroundWorker();
        }
    }
}