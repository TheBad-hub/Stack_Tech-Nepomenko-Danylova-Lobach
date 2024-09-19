namespace AtmLibrary
{
    public class Account
    {
        public string CardNumber { get; private set; }
        public string Owner { get; private set; }
        public decimal Balance { get; private set; }
        private string PinCode;
        private List<string> transactions;

        public Account(string cardNumber, string owner, decimal balance, string pinCode)
        {
            CardNumber = cardNumber;
            Owner = owner;
            Balance = balance;
            PinCode = pinCode;
            transactions = new List<string>();
        }

        public void Withdraw(decimal amount)
        {
            Balance -= amount;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void AddTransaction(string transaction)
        {
            transactions.Add($"{DateTime.Now}: {transaction}");
        }

        public List<string> GetTransactionHistory()
        {
            return transactions;
        }

        public bool ValidatePin(string pin)
        {
            return PinCode == pin;
        }
    }
    public class AutomatedTellerMachine
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public decimal CashAmount { get; private set; }

        public AutomatedTellerMachine(int id, string location, decimal initialCashAmount)
        {
            Id = id;
            Location = location;
            CashAmount = initialCashAmount;
        }

        public void DispenseCash(decimal amount)
        {
            if (CashAmount >= amount)
            {
                CashAmount -= amount;
            }
            else
            {
                throw new InvalidOperationException("ATM has insufficient funds.");
            }
        }

        public void RefillCash(decimal amount)
        {
            CashAmount += amount;
        }
    }

    public class Bank
    {
        public string Name { get; set; }
        public List<AutomatedTellerMachine> Atms { get; private set; }

        public Bank(string name)
        {
            Name = name;
            Atms = new List<AutomatedTellerMachine>();
        }

        public void AddAtm(AutomatedTellerMachine atm)
        {
            Atms.Add(atm);
        }

        public AutomatedTellerMachine? GetAtmById(int id)
        {
            return Atms.FirstOrDefault(atm => atm.Id == id);
        }
    }

    public class BankInitializer
    {
        public Bank? bank { get; private set; }
        public AutomatedTellerMachine? atm { get; private set; }

        public Dictionary<string, Account> InitializeBank()
        {
            bank = new Bank("MyBank");
            atm = new AutomatedTellerMachine(1, "Main Street", 10000);
            bank.AddAtm(atm);

            var accounts = new Dictionary<string, Account>();

            var account1 = new Account("0123456789", "Harry Potter", 5000, "1234");
            var account2 = new Account("9876543210", "Jack Napier a.k.a. Joker", 3000, "4321");

            accounts.Add(account1.CardNumber, account1);
            accounts.Add(account2.CardNumber, account2);

            return accounts;
        }
    }

}
