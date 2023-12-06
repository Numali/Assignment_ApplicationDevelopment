using System;
namespace Assignment
{

    public class BankAccount
    {
        private string accountNumber;
        private decimal balance;

        public BankAccount(string accountNumber)
        {
            this.accountNumber = accountNumber;
            this.balance = 0;
        }

        public void Deposit(decimal amount)
        {
            balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (balance >= amount)
                balance -= amount;
            else
                Console.WriteLine("Insufficient funds!");
        }

        public decimal GetBalance()
        {
            return balance;
        }
    }
}
