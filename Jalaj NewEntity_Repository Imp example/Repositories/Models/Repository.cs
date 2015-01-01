using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories.Intefaces;

namespace Repositories.Models
{
    public class Repository<T> : IRepository<T> where T : class
    {
       // public virtual DbSet<TEntity> Set<TEntity>() where TEntity : class;
        public DbSet<T> context;
       public Repository(DbContext dBcontext)
       {
           context = dBcontext.Set<T>();
       }

       public void Insert(T entity)
       {
         //  DataTable.InsertOnSubmit(entity);
           context.Add(entity);
       }


       public void Delete(T entity)
       {
           //DataTable.DeleteOnSubmit(entity);
           context.Remove(entity);
       }

      

       public System.Linq.IQueryable<T> GetAll()
       {
           return context;
       }

       public System.Linq.IQueryable<T> SearchFor(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
       {
           return context.Where(predicate);
       }

       // public IQueryable<T> All
       // {
       //     get { return context; }
       // }
        
       ////public IQueryable<Order> AllIncluding(params Expression<Func<Order, object>>[] includeProperties)
       //// {
       ////     IQueryable<Order> query = context.Orders;
       ////     foreach (var includeProperty in includeProperties)
       ////     {
       ////         query = query.Include(includeProperty);
       ////     }
       ////     return query;
       //// }
       // public Order Find(int id)
       // {
       //     return context.Orders.Find(id);
       // }
       // public void InsertOrUpdate(Order employee)
       // {
       //     if (employee.CustomerID == default(int))
       //     {
       //         // New entity
       //         context.Orders.Add(employee);
       //     }
       //     else
       //     {
       //         // Existing entity
       //         context.Entry(employee).State = EntityState.Modified;
       //     }
       // }
       // public void Delete(int id)
       // {
       //     var employee = context.Orders.Find(id);
       //     context.Orders.Remove(employee);
       // }
       // public void Save()
       // {
       //     context.SaveChanges();
       // }

       // public void Dispose()
       // {
       //     context.Dispose();
       // }
    }
}
