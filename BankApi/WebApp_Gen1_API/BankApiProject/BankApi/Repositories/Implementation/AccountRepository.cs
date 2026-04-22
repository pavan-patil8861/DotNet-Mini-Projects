

using BankApi.Data;
using BankApi.Models;
using BankApi.Repositories.Interfaces;

namespace BankApi.Repositories.Implementation
{
    public class AccountRepository(AppDbContext context) : GenericRepository<BankAccount>(context), IAccountRepository
    {
        private readonly AppDbContext _context = context;

        public bool Deposit(int id, double amount)
        {
            if (_context.Accounts.Find(id) != null && amount > 0)
            {
                _context.Accounts.Find(id).Balance += amount;
                return _context.SaveChanges() > 0;
            }


            return false;
        }

        public bool Withdraw(int id, double amount)
        {
            BankAccount? acc = _context.Accounts.Find(id);
            if (acc != null && amount > 0)
            {
                if (acc.Balance >= amount)
                {
                }
                else
                {
                    return false;
                }

                acc.Balance -= amount;
                return _context.SaveChanges() > 0;
            }

            return false;
        }
    }
}