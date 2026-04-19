using OrderApi.Data;
using OrderApi.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace OrderApi.Repositories.Implementation
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly AppDbContext _context;

        public GenericRepository(AppDbContext context)
        {
            _context = context;
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public bool Add(T entity)
        {
            _context.Set<T>().Add(entity);
            return _context.SaveChanges() > 0;
        }

        public bool Update(T entity)
        {
            _context.Set<T>().Update(entity);
            return _context.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            T data = _context.Set<T>().Find(id);
            if (data == null)
            {
                return false;
            }

            _context.Set<T>().Remove(data);
            return _context.SaveChanges() > 0;
        }
    }
}