using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;


namespace Repositories
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new CustomerModel())
            {
                Console.Write("enter the id of product ");
                var id = Console.ReadLine();
                Console.Write("enter the name of product ");
                var name = Console.ReadLine();
                var product = new Product { Name = name, ProductID = Convert.ToInt32(id) };
                db.Products.Add(product);
                db.SaveChanges();


                var query = from b in db.Products
                            orderby b.Name
                            select b;
                Console.WriteLine("All Products in the database:");
                foreach (var item in query)
                {
                    Console.WriteLine(item.ProductID + " " + item.Name);
                }
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();

            }
        }
    }
}
