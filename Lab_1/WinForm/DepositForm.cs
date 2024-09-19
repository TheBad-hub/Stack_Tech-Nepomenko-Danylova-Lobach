
using AtmLibrary;

namespace WinForm
{
    public partial class DepositForm : Form
    {
        private Account currentAccount;

        public DepositForm(Account account)
        {
            InitializeComponent();
            currentAccount = account;
        }
    }
}
