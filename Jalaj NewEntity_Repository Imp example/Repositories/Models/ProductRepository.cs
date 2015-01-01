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
   public class ProductRepository:Repository<Product>,IProductRepository
    {
       public ProductRepository(DbContext datacontext)
           : base(datacontext)
       { }

       public IEnumerable<Product> FindProductByOrderItems(List<OrderItem> orderitems)
       {
           //var se = context.Where(s => orderitems.Select(so => so.ProductID).Equals(s.ProductID)).ToList();

           context.Where(q => orderitems.Select(p => p.ProductID).Contains(q.ProductID));

           return context.Where(s => orderitems.Select(p=>p.OrderID).Equals(s.ProductID));

           //var SE = DataTable.Where(s => orderitems
           //                .Select(so => so.ProductID)
           //                .Contains(s.ProductID))
          // .ToList();
          // return se;

       }
    }
}
