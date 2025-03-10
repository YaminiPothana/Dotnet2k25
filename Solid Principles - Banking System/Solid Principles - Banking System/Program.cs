using System;
using BankingSystem.Models;
using BankingSystem.Services;
using BankingSystem.Notifications;

namespace BankingSystem
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== Welcome to Banking System ===");

            Notifier notifier = new Notifier();
            AccountService accountService = new AccountService(notifier);

            BankAccount mySavings = new SavingsAccount("Alice", 5000);
            mySavings.Deposit(1000);
            mySavings.Withdraw(200);
            accountService.ProcessAccount(mySavings);

            BankAccount myCurrent = new CurrentAccount("Bob", 3000);
            accountService.ProcessAccount(myCurrent);
        }
    }
}
