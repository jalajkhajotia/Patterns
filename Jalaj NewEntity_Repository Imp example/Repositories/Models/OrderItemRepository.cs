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
    public class OrderItemRepository : Repository<OrderItem>, IOrderItemRepository
    {

        public OrderItemRepository(DbContext datacontext)
            : base(datacontext)
        {


        }

        public IQueryable<OrderItem> FindItemsByOrder(Order order)
        {
            return context.Where(x => x.OrderID.Equals(order.OrderID));

        }
    }
}
