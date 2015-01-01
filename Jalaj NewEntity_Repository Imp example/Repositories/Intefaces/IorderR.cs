using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Repositories.Intefaces
{
  public  interface IorderR
    {
        IQueryable<Order> All { get; }
       // IQueryable<Order> AllIncluding(params Expression<Func<Order, object>>[] includeProperties);
        Order Find(int id);
        void InsertOrUpdate(Order employee);
        void Delete(int id);
        void Save();
    }
}
