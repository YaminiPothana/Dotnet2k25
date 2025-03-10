using System;

namespace BankingSystem.Models
{
    public class CurrentAccount : BankAccount
    {
        public CurrentAccount(string accountHolder, double initialBalance)
            : base(accountHolder, initialBalance)
        {
        }

        public override void DisplayAccountType()
        {
            Console.WriteLine("This is a Current Account.");
        }
    }
}
