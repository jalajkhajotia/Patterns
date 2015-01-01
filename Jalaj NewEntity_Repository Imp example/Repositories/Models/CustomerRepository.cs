using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Repositories.Intefaces;

namespace Repositories.Models
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {

        public CustomerRepository(DbContext datacontext)
            : base(datacontext)
        {


        }

        public IQueryable<Product> FindProductsByCustomer(Customer customer)
        {

            return null;
            // return DataTable.Where(x=>x.OrderItems.Equals(new OrderItemRepository()));

        }
    }
}
