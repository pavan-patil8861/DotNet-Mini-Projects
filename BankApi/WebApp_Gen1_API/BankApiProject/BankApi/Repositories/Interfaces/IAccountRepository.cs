

using BankApi.Models;
using BankApi.Repositories.Implementation;

namespace BankApi.Repositories.Interfaces
{
    public interface IAccountRepository : IGenericRepository<BankAccount>
    {
        bool Deposit(int id, double amount);
        bool Withdraw(int id, double amount);
    }
}