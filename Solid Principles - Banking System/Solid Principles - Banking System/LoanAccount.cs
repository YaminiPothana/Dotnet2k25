using System;

namespace BankingSystem.Models
{
    public class LoanAccount : BankAccount
    {
        private const double LoanInterestRate = 0.08;

        public LoanAccount(string accountHolder, double loanAmount)
            : base(accountHolder, -loanAmount) // Loan accounts start with negative balance
        {
        }

        public override void Withdraw(double amount)
        {
            Console.WriteLine("Withdrawals are not allowed in loan accounts.");
        }

        public override void DisplayAccountType()
        {
            Console.WriteLine("This is a Loan Account.");
        }

        public double CalculateLoanInterest()
        {
            return Balance * LoanInterestRate;
        }
    }
}
