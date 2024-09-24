namespace AtmLibrary
{
    public class Account
    {
        public string CardNumber { get; private set; }
        public string Owner { get; private set; }
        public decimal Balance { get; private set; }
        private string PinCode;
        private List<Transaction> transactions;

        public Account(string cardNumber, string owner, decimal balance, string pinCode)
        {
            CardNumber = cardNumber;
            Owner = owner;
            Balance = balance;
            PinCode = pinCode;
            transactions = new List<Transaction>();
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Withdrawal amount must be greater than zero.");
            }

            if (Balance >= amount)
            {
                Balance -= amount;
                AddTransaction(new Transaction(-amount, "Withdrawal"));
            }
            else
            {
                throw new InvalidOperationException("Insufficient funds.");
            }
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount must be greater than zero.");
            }

            Balance += amount;
            AddTransaction(new Transaction(amount, "Deposit"));
        }

        public void TransferMoney(Account targetAccount, decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Transfer amount must be greater than zero.");
            }

            if (targetAccount.CardNumber == this.CardNumber)
            {
                throw new InvalidOperationException("Cannot transfer money to the same account.");
            }

            if (Balance < amount)
            {
                throw new InvalidOperationException("Insufficient funds.");
            }

            Balance -= amount;
            targetAccount.Deposit(amount);
            AddTransaction(new Transaction(-amount, $"Transfer to {targetAccount.Owner}"));
            targetAccount.AddTransaction(new Transaction(amount, $"Transfer from {Owner}"));
        }

        public void AddTransaction(Transaction transaction)
        {
            transactions.Add(transaction);
        }

        public List<Transaction> GetTransactionHistory()
        {
            return transactions;
        }

        public bool ValidatePin(string pin)
        {
            return PinCode == pin;
        }
    }

    public class Transaction
    {
        public DateTime Date { get; private set; }
        public decimal Amount { get; private set; }
        public string Description { get; private set; }

        public Transaction(decimal amount, string description)
        {
            Date = DateTime.Now;
            Amount = amount;
            Description = description;
        }

        public override string ToString()
        {
            return $"{Date}: {Description}, Amount: {Amount}";
        }
    }

    public static class TransactionFilters
    {
        public static List<Transaction> FilterByCurrentDay(List<Transaction> transactions)
        {
            return transactions
                .Where(t => t.Date.Date == DateTime.Now.Date)
                .ToList();
        }

        public static List<Transaction> FilterByCurrentWeek(List<Transaction> transactions)
        {
            var startOfWeek = DateTime.Now.AddDays(-(int)DateTime.Now.DayOfWeek + 1); // Monday
            return transactions
                .Where(t => t.Date >= startOfWeek && t.Date <= DateTime.Now)
                .ToList();
        }

        public static List<Transaction> FilterByCurrentMonth(List<Transaction> transactions)
        {
            var startOfMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            return transactions
                .Where(t => t.Date >= startOfMonth && t.Date <= DateTime.Now)
                .ToList();
        }
    }

    public class AutomatedTellerMachine
    {
        public string Name { get; set; }
        public decimal CashAmount { get; private set; }
        public double Latitude { get; set; } // Latitude
        public double Longitude { get; set; } // Longitude

        public AutomatedTellerMachine(string name, double latitude, double longitude, decimal initialCashAmount)
        {
            Name = name;
            Latitude = latitude;
            Longitude = longitude;
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

        private double ToRadians(double degrees)
        {
            return degrees * Math.PI / 180.0;
        }

        public double CalculateDistance(AutomatedTellerMachine otherATM)
        {
            const double EARTH_RADIUS = 6371.0; // Earth radius in kilometers

            double lat1 = ToRadians(this.Latitude);
            double lon1 = ToRadians(this.Longitude);
            double lat2 = ToRadians(otherATM.Latitude);
            double lon2 = ToRadians(otherATM.Longitude);

            double dlat = lat2 - lat1;
            double dlon = lon2 - lon1;

            double a = Math.Pow(Math.Sin(dlat / 2), 2) +
                       Math.Cos(lat1) * Math.Cos(lat2) * Math.Pow(Math.Sin(dlon / 2), 2);

            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

            return EARTH_RADIUS * c;
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

        public AutomatedTellerMachine? GetAtmByName(string name)
        {
            return Atms.FirstOrDefault(atm => atm.Name == name);
        }

        public List<AutomatedTellerMachine> GetNearestATMs(AutomatedTellerMachine currentATM, int count)
        {
            return Atms.OrderBy(atm => atm.CalculateDistance(currentATM)).Take(count).ToList();
        }
    }

    public class BankInitializer
    {
        public Bank? bank { get; private set; }
        public AutomatedTellerMachine? atm { get; private set; }
        private Dictionary<string, Account>? accounts;

        // Constructor that initializes with Bank, ATM, and Accounts
        public BankInitializer(Bank bank, AutomatedTellerMachine atm, Dictionary<string, Account> accounts)
        {
            this.bank = bank;
            this.atm = atm;
            this.accounts = accounts;
        }

        // Default constructor
        public BankInitializer()
        {
        }

        public Dictionary<string, Account> GetAccounts()
        {
            if (accounts != null)
            {
                return accounts;
            }

            // Initialize bank, ATM, and accounts in the default way if accounts are not provided
            bank = new Bank("MyBank");

            List<AutomatedTellerMachine> atms = new List<AutomatedTellerMachine>
            {
                new AutomatedTellerMachine("ATM 1", 50.4501, 30.5234, 10000),
                new AutomatedTellerMachine("ATM 2", 51.4511, 29.5244, 15000),
                new AutomatedTellerMachine("ATM 3", 52.4521, 27.5254, 6500),
                new AutomatedTellerMachine("ATM 4", 48.1214, 39.9954, 8500),
            };

            foreach (var atm in atms)
            {
                bank.AddAtm(atm);
            }

            atm = new AutomatedTellerMachine("ATM MAIN", 48.0805, 37.4440, 10000);
            bank.AddAtm(atm);

            accounts = new Dictionary<string, Account>
            {
                { "0123456789", new Account("0123456789", "Harry Potter", 5000, "1234") },
                { "9876543210", new Account("9876543210", "Jack Napier a.k.a. Joker", 3000, "4321") }
            };

            return accounts;
        }
    }
}
