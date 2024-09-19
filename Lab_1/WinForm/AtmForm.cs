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

