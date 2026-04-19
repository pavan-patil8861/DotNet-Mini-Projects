using OrderApi.Data;
using OrderApi.Models;
using OrderApi.Repositories.Interfaces;

namespace OrderApi.Repositories.Implementation
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        private readonly AppDbContext _context;

        public OrderRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public bool UpdateStatus(int id, string status)
        {
            Order order = _context.Orders.Find(id);

            if (order == null)
            {
                return false;
            }

            order.Status = status;
            return _context.SaveChanges() > 0;
        }
    }
}