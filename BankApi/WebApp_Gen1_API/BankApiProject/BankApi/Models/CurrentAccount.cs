using BankApi.Models;


namespace BankApi.Models
{
    public class CurrentAccount : BankAccount
    {
        public double OverdraftLimit { get; set; }
    }
}