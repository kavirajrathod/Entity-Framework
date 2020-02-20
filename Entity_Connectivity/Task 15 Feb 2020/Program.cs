using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_15_Feb_2020
{
    class Program
    {
        static EmployeeDBEntities dbt = new EmployeeDBEntities();
        static void Main(string[] args)
        {

           // Insertdata();
            
            Display();
            Console.ReadLine();
        }

        public static void Insertdata()
        {
            Console.WriteLine("Enter the Category Id");
            int Cid1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Category name");
            string Cname1 = Console.ReadLine();


            var category = new Category
            {
                Cid = Cid1,
                Cname = Cname1

            };
            dbt.Categories.Add(category);
            dbt.SaveChanges();


            Console.WriteLine("Enter the Product Id");
            int pid = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Title");
            string ttl = Console.ReadLine();
            Console.WriteLine("Enter Price");
            int pr = int.Parse(Console.ReadLine());


            var product = new Product
            {
                Pid = pid,
                Title = ttl,
                Price=pr

            };
            dbt.Products.Add(product);
            dbt.SaveChanges();
        }


        public static void Display()
        {
            Console.WriteLine("All Categories are::\n");
            var Category = dbt.Categories;
            foreach (var c in Category)
            {
                Console.WriteLine("{0}\t{1}", c.Cid, c.Cname);
            }

            Console.WriteLine();

            Console.WriteLine("All Products are::\n");
            var product = dbt.Products;
            foreach (var d in product)
            {
                Console.WriteLine("{0}\t{1}\t{2}", d.Pid, d.Title, d.Price);
            }
        }
    }
}
