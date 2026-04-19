using Microsoft.AspNetCore.Mvc;
using OrderApi.Models;
using OrderApi.Services.Interfaces;

namespace OrderApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _service;

        public OrderController(IOrderService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_service.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_service.GetById(id));
        }

        [HttpPost]
        public IActionResult Create(Order order)
        {
            return Ok(_service.Create(order));
        }

        [HttpPut]
        public IActionResult Update(Order order)
        {
            return Ok(_service.Update(order));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_service.Delete(id));
        }

        [HttpPatch("status")]
        public IActionResult UpdateStatus(int id, string status)
        {
            return Ok(_service.UpdateStatus(id, status));
        }
    }
}