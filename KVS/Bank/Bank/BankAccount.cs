namespace Bank
{
    public abstract class BankAccount
    {
        protected decimal balance;

        public string Name { get; set; }
        public decimal Balance => balance;

        public bool Deposit (decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
                return true;
            }
            return false;
        }

        public bool Withdraw(decimal amount)
        {
            if (amount > 0)
            {
                balance -= amount;
                return true;
            }
            return false;
        }

        public bool Transfer(decimal amount, BankAccount account)
        {
            if (account == null)
                return false;

            if (amount > 0)
            {
                balance-=amount;
                account.Deposit(amount);
                return true;
            }

            return false;
        }

    }
}