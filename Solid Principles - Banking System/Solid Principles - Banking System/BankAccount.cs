using System;

namespace BankingSystem.Models
{
    public abstract class BankAccount
    {
        public string AccountHolder { get; set; }
        public double Balance { get; protected set; }

        public BankAccount(string accountHolder, double initialBalance)
        {
            AccountHolder = accountHolder;
            Balance = initialBalance;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine($"{amount} deposited. New balance: {Balance}");
        }

        public virtual void Withdraw(double amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"{amount} withdrawn. New balance: {Balance}");
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
            }
        }

        public abstract void DisplayAccountType();

        public virtual double GetCalculateInterest()
        {
            return 0; // No interest for current accounts
        }
    }
}
