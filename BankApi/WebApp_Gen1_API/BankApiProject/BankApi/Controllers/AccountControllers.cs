

using Microsoft.AspNetCore.Mvc;
using BankApi.Models;
using BankApi.Services.Interfaces;

namespace BankApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _service;

        public AccountController(IAccountService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll() => Ok(_service.GetAll());

        [HttpGet("{id}")]
        public IActionResult GetById(int id) => Ok(_service.GetById(id));

        [HttpPost]
        public IActionResult Create(BankAccount acc) => Ok(_service.Create(acc));

        [HttpPut]
        public IActionResult Update(BankAccount acc) => Ok(_service.Update(acc));

        [HttpDelete("{id}")]
        public IActionResult Delete(int id) => Ok(_service.Delete(id));

        [HttpPost("deposit")]
        public IActionResult Deposit(int id, double amount) => Ok(_service.Deposit(id, amount));

        [HttpPost("withdraw")]
        public IActionResult Withdraw(int id, double amount) => Ok(_service.Withdraw(id, amount));
    }
}