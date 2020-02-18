using System;

namespace UnitTesting
{
    public class BankAccaunt
    {
        private decimal balance;
        public decimal Balance
        {
            get
            {
                return balance;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Balance can not be negative.");
                }
                balance = value;
            }
        }
        public BankAccaunt(decimal balance)
        {
            this.Balance = balance;
        }
        public void Deposit(decimal sum)
        {
            if (sum <= 0)
            {
                throw new ArgumentException("Sum must be positive.");
            }
            Balance += sum;
        }
        public decimal Withdraw(decimal sum)
        {
            if (sum <= 0)
            {
                throw new ArgumentException("Sum must be positive number.");
            }
            Balance -= sum;
            return Balance;
        }

    }
}
