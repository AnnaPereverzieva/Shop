using System.Collections.Generic;

namespace Shop.Domain.Repositories
{
    public interface IRepository<T> where T : class
    {
        IList<T> GetAll();
        void Update(T entity);
        void Delete(T entity);
        void Add(T entity);
    }
}
