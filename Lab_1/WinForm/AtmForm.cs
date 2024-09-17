using AtmLibrary;

namespace WinForm
{
    public partial class AtmForm : Form
    {
        private Account currentAccount;
        private AutomatedTellerMachine atm;

        public AtmForm(Account account, AutomatedTellerMachine atm)
        {
            InitializeComponent();
            currentAccount = account;
            this.atm = atm;
            UpdateAccountInfo(); // Оновлюємо інформацію на формі
        }

    }
}

