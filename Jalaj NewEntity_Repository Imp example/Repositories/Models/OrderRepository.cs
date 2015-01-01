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
    public class OrderRepository : Repository<Order>, IOrderRepository
    {

        public OrderRepository(DbContext datacontext)
            : base(datacontext)
        {


        }

        public IQueryable<Order> FindOrdersByCustomer(Customer customer)
        {

            return context.Where(x => x.Customer.Equals(customer));

        }
    }
}
