using BankingSystem.Models;
using BankingSystem.Notifications;
using System;

namespace BankingSystem.Services
{
    public class AccountService
    {
        private readonly Notifier _notifier;

        public AccountService(Notifier notifier)
        {
            _notifier = notifier;
        }

        public void ProcessAccount(BankAccount account)
        {
            Console.WriteLine("\nProcessing account...");
            account.DisplayAccountType();
            Console.WriteLine($"Account Holder: {account.AccountHolder}");
            Console.WriteLine($"Current Balance: {account.Balance}");
            _notifier.Notify("Your account has been processed.");
        }
    }
}
