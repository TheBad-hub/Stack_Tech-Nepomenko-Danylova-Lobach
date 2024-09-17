namespace AtmLibrary
{
    public class Account
    {
        public string CardNumber { get; set; }
        public string OwnerName { get; set; }
        public decimal Balance { get; set; }
        public List<string> TransactionHistory {  get; private set; }
        
        public Account(string cardNumber, string ownerName, decimal initialBalance) 
        {
            CardNumber = cardNumber;
            OwnerName = ownerName;
            Balance = initialBalance;
            TransactionHistory = new List<string>();

        }
        public void Deposit(decimal amount)
        {
            Balance += amount;
            TransactionHistory.Add($"Deposited: {amount} - {DateTime.Now}");
        }

        public void Withdraw(decimal amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                TransactionHistory.Add($"Withdrawn: {amount} - {DateTime.Now}");
            }
            else
            {
                throw new InvalidOperationException("Insufficient funds.");
            }
        }

        public string GetTransactionHistory(DateTime from, DateTime to)
        {
            var history = TransactionHistory.Where(t => DateTime.Parse(t.Split('-')[1]) >= from && DateTime.Parse(t.Split('-')[1]) <= to);
            return string.Join("\n", history);
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
}
