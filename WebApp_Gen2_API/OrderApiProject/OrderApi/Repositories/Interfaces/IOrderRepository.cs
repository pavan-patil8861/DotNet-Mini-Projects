using OrderApi.Models;

namespace OrderApi.Repositories.Interfaces
{
    public interface IOrderRepository : IGenericRepository<Order>
    {
        bool UpdateStatus(int id, string status);
    }
}