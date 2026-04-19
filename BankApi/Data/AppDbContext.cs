
using Microsoft.EntityFrameworkCore;
using BankApi.Models;

namespace BankApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<BankAccount> Accounts { get; set; }
    }
}