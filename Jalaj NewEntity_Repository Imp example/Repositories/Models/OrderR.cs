using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Repositories.Intefaces;

namespace Repositories.Models
{
   public class OrderR:IorderR
   {
      public CustomerModel context;
       public OrderR(CustomerModel dbcontext)
       {
            context =dbcontext;
       }
       
        public IQueryable<Order> All
        {
            get { return context.Orders; }
        }
        
       //public IQueryable<Order> AllIncluding(params Expression<Func<Order, object>>[] includeProperties)
       // {
       //     IQueryable<Order> query = context.Orders;
       //     foreach (var includeProperty in includeProperties)
       //     {
       //         query = query.Include(includeProperty);
       //     }
       //     return query;
       // }
        public Order Find(int id)
        {
            return context.Orders.Find(id);
        }
        public void InsertOrUpdate(Order employee)
        {
            if (employee.CustomerID == default(int))
            {
                // New entity
                context.Orders.Add(employee);
            }
            else
            {
                // Existing entity
                context.Entry(employee).State = EntityState.Modified;
            }
        }
        public void Delete(int id)
        {
            var employee = context.Orders.Find(id);
            context.Orders.Remove(employee);
        }
        public void Save()
        {
            context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
