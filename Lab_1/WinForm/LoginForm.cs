using AtmLibrary;
using System.Windows.Forms;

namespace WinForm
{
    public partial class LoginForm : Form
    {
        private Account currentAccount;
        private Bank bank;
        private AutomatedTellerMachine atm;
        private Dictionary<string, Account> accounts = new Dictionary<string, Account>();

        public LoginForm()
        {
            InitializeComponent();
            InitializeBank();
        }
        private void InitializeBank()
        {
            bank = new Bank("MyBank");
            atm = new AutomatedTellerMachine(1, "Main Street", 10000);
            bank.AddAtm(atm);

            var account1 = new Account("0123456789", "Harry Potter", 5000, "1234");
            var account2 = new Account("9876543210", "Jack Napier a.k.a. Joker", 3000, "4321");
            accounts.Add(account1.CardNumber, account1);
            accounts.Add(account2.CardNumber, account2);

        }
    }
}
