using System.Collections.Generic;

namespace OrderApi.Repositories.Interfaces
{
    public interface IGenericRepository<T>
    {
        List<T> GetAll();
        T GetById(int id);
        bool Add(T entity);
        bool Update(T entity);
        bool Delete(int id);
    }
}