using System.Collections.Generic;
using System.Linq;
using Shop.Domain.Model;

namespace Shop.Domain.Repositories
{

    public class CustomerRepository : IRepository<Customers>
    {
        private readonly northwindEntities _context;
        public CustomerRepository()
        {
           _context = new northwindEntities();
        }
        public IList<Customers> GetAll()
        {
            return _context.Customers.ToList();
        }

        public void Update(Customers entity)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(Customers entity)
        {
            throw new System.NotImplementedException();
        }

        public void Add(Customers entity)
        {
            throw new System.NotImplementedException();
        }
    }
    
}
