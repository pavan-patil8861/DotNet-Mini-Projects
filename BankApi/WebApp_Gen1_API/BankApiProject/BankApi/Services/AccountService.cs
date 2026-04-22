using BankApi.DTOs;
using BankApi.Models;
using BankApi.Repositories.Interfaces;
using BankApi.Services.Interfaces;


using BankApi.DTOs;
using BankApi.Models;
using BankApi.Repositories.Interfaces;
using BankApi.Services.Interfaces;

namespace BankApi.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _repo;

        public AccountService(IAccountRepository repo)
        {
            _repo = repo;
        }

        public ResponseDto GetAll()
        {
            var data = _repo.GetAll();
            return new ResponseDto { Message = "Accounts fetched successfully", Data = data };
        }

        public ResponseDto GetById(int id)
        {
            var data = _repo.GetById(id);
            if (data == null)
                return new ResponseDto { Message = "Account not found" };

            return new ResponseDto { Message = "Account fetched successfully", Data = data };
        }

        public ResponseDto Create(BankAccount acc)
        {
            if (acc == null)
                return new ResponseDto { Message = "Invalid data" };

            bool result = _repo.Add(acc);

            return new ResponseDto
            {
                Message = result ? "Account created successfully" : "Failed to create account",
                Data = acc
            };
        }

        public ResponseDto Update(BankAccount acc)
        {
            bool result = _repo.Update(acc);

            return new ResponseDto
            {
                Message = result ? "Account updated successfully" : "Update failed"
            };
        }

        public ResponseDto Delete(int id)
        {
            bool result = _repo.Delete(id);

            return new ResponseDto
            {
                Message = result ? "Account deleted successfully" : "Delete failed"
            };
        }

        public ResponseDto Deposit(int id, double amount)
        {
            bool result = _repo.Deposit(id, amount);

            return new ResponseDto
            {
                Message = result ? "Amount deposited successfully" : "Deposit failed"
            };
        }

        public ResponseDto Withdraw(int id, double amount)
        {
            bool result = _repo.Withdraw(id, amount);

            return new ResponseDto
            {
                Message = result ? "Amount withdrawn successfully" : "Withdraw failed"
            };
        }
    }
}