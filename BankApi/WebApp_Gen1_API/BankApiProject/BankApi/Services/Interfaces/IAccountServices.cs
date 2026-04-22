using BankApi.DTOs;
using BankApi.Models;


using BankApi.Models;
using BankApi.DTOs;

namespace BankApi.Services.Interfaces
{
    public interface IAccountService
    {
        ResponseDto GetAll();
        ResponseDto GetById(int id);
        ResponseDto Create(BankAccount acc);
        ResponseDto Update(BankAccount acc);
        ResponseDto Delete(int id);
        ResponseDto Deposit(int id, double amount);
        ResponseDto Withdraw(int id, double amount);
    }
}