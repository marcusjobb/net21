// -----------------------------------------------------------------------------------------------
//  Class1.cs by Marcus Medina, Copyright (C) 2021, Codic Education AB.
//  Published under Apache License 2.0 (Apache-2.0) License
// -----------------------------------------------------------------------------------------------

namespace Bank
{
    internal class BankAccount
    {
        private decimal balance;
        private readonly string accountNumber="123123-2322";
        private readonly string accountName="Salary";

        public void Withdraw (decimal balance)
        {
            if (balance > this.balance)
            {
                throw new Exception("Insufficient funds");
            }
            else if (balance < 0)
            {
                throw new Exception("Invalid amount");
            }
            else
            {
                this.balance -= balance;
            }
            this.balance -= balance;
        }

        public void Deposit (decimal balance)
        {
            if (balance < 0)
            {
                throw new Exception("Invalid amount");
            }
            else
            {
                this.balance += balance;
            }
        }
    }
}