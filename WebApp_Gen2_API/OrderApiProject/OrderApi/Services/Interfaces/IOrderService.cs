using OrderApi.DTOs;
using OrderApi.Models;

namespace OrderApi.Services.Interfaces
{
    public interface IOrderService
    {
        ResponseDto GetAll();
        ResponseDto GetById(int id);
        ResponseDto Create(Order order);
        ResponseDto Update(Order order);
        ResponseDto Delete(int id);
        ResponseDto UpdateStatus(int id, string status);
    }
}