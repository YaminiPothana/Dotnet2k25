using System;

namespace BankingSystem.Notifications
{
    public class Notifier
    {
        public void Notify(string message)
        {
            // Simple unified notification logic
            Console.WriteLine($"[Notification] {message}");
        }
    }
}
