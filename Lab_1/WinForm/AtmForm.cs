using AtmLibrary;

namespace WinForm
{
    public partial class AtmForm : Form
    {
        private Bank bank;
        private Account currentAccount;
        private AutomatedTellerMachine atm;
        private Dictionary<string, Account>? accounts;

        public AtmForm(BankInitializer initializer, Account account)
        {
            InitializeComponent();
            currentAccount = account;
            this.bank = initializer.bank;
            this.atm = initializer.atm;
            accounts = initializer.GetAccounts();

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
        // test
        private void AtmForm_Load(object sender, EventArgs e)
        {

        }
    }
}

