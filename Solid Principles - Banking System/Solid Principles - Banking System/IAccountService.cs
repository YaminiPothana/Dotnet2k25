using BankingSystem.Models;

namespace BankingSystem.Services
{
    public interface IAccountService
    {
        void ProcessAccount(BankAccount account);
    }
}
