﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Repositories.Intefaces
{
   public interface IProductRepository
    {
       IEnumerable<Product> FindProductByOrderItems(List<OrderItem> orderitems);
    }
}