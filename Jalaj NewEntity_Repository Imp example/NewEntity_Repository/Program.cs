using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Repositories.Intefaces;
using Repositories.Models;
using Ninject;

namespace NewEntity_Repository
{
    class Program
    {
        static void Main(string[] args)
           {
               using (var db = new CustomerModel())
               {
                   //Console.Write("enter the id of product ");
                   //var id = Console.ReadLine();
                   //Console.Write("enter the name of product ");
                   //var name = Console.ReadLine();
                   //var product = new Product { Name = name, ProductID = Convert.ToInt32(id) };
                   //db.Products.Add(product);
                   //db.SaveChanges();
                   ////db.add(product);

                   //var query = from b in db.Products
                   //            orderby b.Name
                   //            select b;
                   //Console.WriteLine("All Products in the database:");
                   //foreach (var item in query)
                   //{
                   //    Console.WriteLine(item.ProductID + " " + item.Name);
                   //}


                 //  var productrepository = new Repository<Product>(db);
                 //var products=  productrepository.GetAll();

                 //foreach (var product in products)
                 //{
                 //    Console.WriteLine(product.Name + "  " + product.ProductID +"  ");
                 //}
                 //     //   OrderR ord = new OrderR(db);

                 //var orderRepository = new Repository<Order>(db);
                 //Order order = orderRepository.SearchFor(o => o.CustomerID == 38).Single();

                 //var orderItemsRepository = new Repository<OrderItem>(db);
                 //var orderitems = orderItemsRepository.SearchFor(ot => ot.OrderID.Equals(order.OrderID));

                 //var productrep = new ProductRepository(db);
                 //var products = productrep.FindProductByOrderItems(orderitems.ToList());


                // Console.WriteLine(" Products for {0} " + Environment.NewLine + "----------------------", order.Customer.Name);

                 //foreach (var or in orderitems)
                 {
                   //  Console.WriteLine(orderitems.ToList()[0].OrderID);
                 }
                 using (IKernel kernel = new StandardKernel())
                 {
                     kernel.Bind<IRepository<Customer>>().To<Repository<Customer>>().WithConstructorArgument("dBcontext", db);

                     kernel.Bind<ICustomerRepository>().To<CustomerRepository>().WithConstructorArgument("dBcontext", db);

                     //var customers = kernel.Get<IRepository<Customer>>().GetAll();
                  Console.WriteLine(    kernel.Get<ICustomerRepository>().FindProductsByCustomer(null));
                     //foreach (var product in customers.ToList())
                     //{
                     //    Console.WriteLine(product.Name);
                     //}

                     var products = kernel.Get<IRepository<Product>>().GetAll();

                     foreach (var product in products.ToList())
                     {
                         Console.WriteLine(product.Name);
                     }
                 }


                // var customerRepository = new Repository<Customer>(db);
                // Customer customer = customerRepository.SearchFor(o => o.Name.Contains("Jalaj")).FirstOrDefault();

                // var orderRepository = new Repository<Order>(db);
                // Order order = orderRepository.SearchFor(o => o.CustomerID == customer.CustomerID).FirstOrDefault();

                // var orderItemsRepository = new Repository<OrderItem>(db);
                // var orderitems = orderItemsRepository.SearchFor(ot => ot.OrderID == order.OrderID);

                //// var productrep = new ProductRepository(db);
                ////var products = productrep.FindProductByOrderItems(orderitems.ToList());


                // //var productRepository = new Repository<Product>(db);
                // //var products = productRepository.SearchFor(ot => ot.ProductID == orderitems).ToList();

                // //foreach (var product in products)
                // {
                //     Console.WriteLine(orderitems.FirstOrDefault().ProductID);
                // }

                //   //  Console.WriteLine(ord.Find(401).CustomerID);
                   Console.WriteLine("Press any key to exit...");
                   Console.ReadKey();

               }
        }
    }
}
