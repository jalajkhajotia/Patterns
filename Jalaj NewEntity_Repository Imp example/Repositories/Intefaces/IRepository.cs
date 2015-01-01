using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace Repositories.Intefaces
{
   public interface IRepository<T>
   {
       //IQueryable<T> All();
       //// IQueryable<Order> AllIncluding(params Expression<Func<Order, object>>[] includeProperties);
       //T Find(int id);
       //void InsertOrUpdate(T entity);
       //void Delete(int id);
       //void Save();

       void Insert(T entity);

       void Delete(T entity);

       IQueryable<T> SearchFor(Expression<Func<T, bool>> predicate);

       IQueryable<T> GetAll();
    }
}
