

using BankApi.Data;
using BankApi.Repositories.Interfaces;


namespace BankApi.Repositories.Implementation
{
    public class GenericRepository<T>(AppDbContext context) : IGenericRepository<T> where T : class
    {
        public List<T> GetAll()
        {
            return [.. context.Set<T>()];
        }

        public T GetById(int id)
        {
            return context.Set<T>().Find(id);
        }

        public bool Add(T entity)
        {
            _ = context.Set<T>().Add(entity);
            return context.SaveChanges() > 0;
        }

        public bool Update(T entity)
        {
            _ = context.Set<T>().Update(entity);
            return context.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            if (context.Set<T>().Find(id) != null)
            {
                _ = context.Set<T>().Remove(context.Set<T>().Find(id));
                return context.SaveChanges() > 0;
            }

            return false;
        }
    }
}