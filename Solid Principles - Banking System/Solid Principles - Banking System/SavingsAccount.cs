using System;

namespace BankingSystem.Models
{
    public class SavingsAccount : BankAccount
    {
        private const double InterestRate = 0.04;

        public SavingsAccount(string accountHolder, double initialBalance)
            : base(accountHolder, initialBalance)
        {
        }

        public override double GetCalculateInterest()
        {
            return Balance * InterestRate;
        }

        public override void DisplayAccountType()
        {
            Console.WriteLine("This is a Savings Account.");
        }
    }
}
