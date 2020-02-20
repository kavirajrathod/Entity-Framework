using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Task_Code
{
    class Program
    {
        static Context ctx = new Context();
        static void Main(string[] args)
        { 
            InsertInitialData();
            ShowAll();

             Console.ReadKey();
        }

        private static void ShowAll()
        {
            var customers = ctx.Customers;
            Console.WriteLine("Customers Data:\n");
            foreach (var cst in customers)
            {
                Console.WriteLine("{0}       {1}",cst.Cust_name,cst.City);
            }

            var products = ctx.Products;
            Console.WriteLine("\n\nProducts Data:\n");
            foreach (var pdt in products)
            {
                Console.WriteLine("{0}      {1}       {2}", pdt.Product_name,pdt.Quantity,pdt.Price);
            }


            var purchases = ctx.Purchases;
            Console.WriteLine("\n\nPurchases Data\n:");
            Console.WriteLine("{0,-8}{1,-14}{2,-8}{3,-15}{4,10:N}{5,8}Rs{6,15}{7,12}{8,19}", "PurchID", "OrderDate", "Pid", "ProductName", "Quantity", "Price", "CustID", "Customename", "City");
            foreach (var pr in purchases)
            {
                Console.WriteLine("{0,-8}{1,-14}{2,-8}{3,-15}{4,10:N}{5,8}{6,15}{7,12}{8,15} "
                    , pr.id,pr.OrderDate.ToShortDateString(),pr.Product_id,pr.Product.Product_name,pr.Product.Quantity,pr.Product.Price,pr.Cust_id,pr.Customer.Cust_name,pr.Customer.City);
            }

        }

        private static void InsertInitialData()
        {
            var customers = new List<Customer>
            {
             new Customer { Cust_name="kaviraj",City="Pune"},
             new Customer { Cust_name="Damodar",City="Chennai"},
             new Customer { Cust_name="Deepak",City="Khandesh"},
             new Customer { Cust_name="Raviraj",City="Mumbai"},
             new Customer { Cust_name="kavi",City="Latur"},
            };
            customers.ForEach(s => ctx.Customers.Add(s));
            ctx.SaveChanges();


            var products = new List<Product>
            {
             new Product { Product_name="Watch",Quantity=2,Price=2500},
             new Product { Product_name="Shirts",Quantity=4,Price=250},
             new Product { Product_name="Jeans",Quantity=1,Price=500},
             new Product { Product_name="T-shirts",Quantity=2,Price=150},
            new Product { Product_name="Rice",Quantity=3,Price=350}
            };
            products.ForEach(p => ctx.Products.Add(p));
            ctx.SaveChanges();

            var purchases = new List<Purchase>
            {
             new Purchase{OrderDate=Convert.ToDateTime("03-Jan-2015"),Product_id=1,Cust_id=2 },
             new Purchase{OrderDate=Convert.ToDateTime("13-Jun-2019"),Product_id=2,Cust_id=1 },
             new Purchase{OrderDate=Convert.ToDateTime("01-July-2020"),Product_id=3,Cust_id=2 },
             new Purchase{OrderDate=Convert.ToDateTime("25-Sep-2016"),Product_id=3,Cust_id=3 },
             new Purchase{OrderDate=Convert.ToDateTime("18-May-2014"),Product_id=4,Cust_id=2 }
            };

            purchases.ForEach(pp => ctx.Purchases.Add(pp));
            ctx.SaveChanges();

            
        }






        /* private static void InsertData()
         {
             Customer c = new Customer();



             Console.WriteLine("Enter Customer Name");
             c.Cust_name = Console.ReadLine();

             Console.WriteLine("Enter Customer  City");
             c.City = Console.ReadLine();

             Console.WriteLine("Product-List");
             c.Product_List= ProductDataList();

             ct.Customers.Add(c);
             ct.SaveChanges();
             Console.WriteLine("Inserted Successfully::");

         }*/

        /* public static List<Product>  ProductDataList()
             {
             Product p = new Product();
             List<Product> list = new List<Product>();
             Console.WriteLine("Enter Product Name");
             p.Product_name = Console.ReadLine();

             Console.WriteLine("Enter Quantity");
             p.Quantity = int.Parse(Console.ReadLine());

             Console.WriteLine("Enter Price");
             p.Price = double.Parse(Console.ReadLine());

             list.Add(p);
             return list;
         }*/
    }
  }

