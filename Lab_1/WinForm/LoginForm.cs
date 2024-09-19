using AtmLibrary;
using System.Windows.Forms;

namespace WinForm
{
    public partial class LoginForm : Form
    {
        private readonly Dictionary<string, Account>? accounts; 
        private Account? currentAccount;  
        private readonly AutomatedTellerMachine atm;  

        public LoginForm(Dictionary<string, Account> accounts, AutomatedTellerMachine atm)
        {
            InitializeComponent();
            this.accounts = accounts;
            this.atm = atm;  
        }
    }
}
