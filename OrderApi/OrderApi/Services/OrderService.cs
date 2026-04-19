using OrderApi.DTOs;
using OrderApi.Models;
using OrderApi.Repositories.Interfaces;
using OrderApi.Services.Interfaces;

namespace OrderApi.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _repo;

        public OrderService(IOrderRepository repo)
        {
            _repo = repo;
        }

        public ResponseDto GetAll()
        {
            return new ResponseDto
            {
                Message = "Orders fetched successfully",
                Data = _repo.GetAll()
            };
        }

        public ResponseDto GetById(int id)
        {
            Order data = _repo.GetById(id);

            if (data == null)
                return new ResponseDto { Message = "Order not found" };

            return new ResponseDto
            {
                Message = "Order fetched successfully",
                Data = data
            };
        }

        public ResponseDto Create(Order order)
        {
            bool result = _repo.Add(order);

            return new ResponseDto
            {
                Message = result ? "Order created successfully" : "Creation failed",
                Data = order
            };
        }

        public ResponseDto Update(Order order)
        {
            bool result = _repo.Update(order);

            return new ResponseDto
            {
                Message = result ? "Order updated successfully" : "Update failed"
            };
        }

        public ResponseDto Delete(int id)
        {
            bool result = _repo.Delete(id);

            return new ResponseDto
            {
                Message = result ? "Order deleted successfully" : "Delete failed"
            };
        }

        public ResponseDto UpdateStatus(int id, string status)
        {
            bool result = _repo.UpdateStatus(id, status);

            return new ResponseDto
            {
                Message = result ? "Status updated successfully" : "Status update failed"
            };
        }
    }
}