using AtmLibrary;
using System.Windows.Forms;

namespace WinForm
{
    public partial class LoginForm : Form
    {
        private readonly Dictionary<string, Account>? accounts; 
        private Account? currentAccount;  
        private readonly AutomatedTellerMachine? atm;
        BankInitializer? initializer;

        public LoginForm(BankInitializer bankInitializer)
        {
            InitializeComponent();
            this.accounts = bankInitializer.GetAccounts();
            this.atm = bankInitializer.atm;
            initializer = bankInitializer;
            this.FormClosing += LoginForm_FormClosing;
        }

        private void LoginForm_FormClosing(object? sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
