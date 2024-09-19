using AtmLibrary;

namespace WinForm
{
    public partial class AtmForm : Form
    {
        private Account currentAccount;
        private AutomatedTellerMachine atm;
        private Dictionary<string, Account>? accounts;

        public AtmForm(Account account, AutomatedTellerMachine atm, Dictionary<string, Account> accounts)
        {
            InitializeComponent();
            currentAccount = account;
            this.atm = atm;
            this.accounts = accounts;

            // Оновлюємо інформацію на формі
            UpdateNameInfo();
            UpdateBalanceInfo();
            this.FormClosing += AtmForm_FormClosing;
        }

        // Оброблювач події закриття форми
        private void AtmForm_FormClosing(object? sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

