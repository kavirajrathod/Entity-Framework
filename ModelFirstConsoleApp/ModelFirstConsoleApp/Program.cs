using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelFirstConsoleApp
{
    class Program
    {
        static ModelDBContainer db = new ModelDBContainer();
        static void Main(string[] args)
        {
            Insertdata();
            Display();

        }

        public static void Insertdata()
        {
            Console.WriteLine("Enter the Category Id");
            int cid = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Category name");
            string ctl = Console.ReadLine();


            var category = new Category
            {
                Cid = cid,
                Ctitle= ctl

            };

            db.Categories.Add(category);
            db.SaveChanges();


            Console.WriteLine("Enter the Product Id");
            int pid = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Title");
            string ttl = Console.ReadLine();
            Console.WriteLine("Enter Price");
            int pr = int.Parse(Console.ReadLine());


            var product = new Product
            {
                Pid = pid,
                Ptitle = ttl,
                Price = pr

            };
            db.Products.Add(product);
            db.SaveChanges();
        }


        public static void Display()
        {
            Console.WriteLine("All Categories are::\n");
            var Category = db.Categories;
            foreach (var c in Category)
            {
                Console.WriteLine("{0}\t{1}", c.Cid, c.Ctitle);
            }

            Console.WriteLine();

            Console.WriteLine("All Products are::\n");
            var product = db.Products;
            foreach (var d in product)
            {
                Console.WriteLine("{0}\t{1}\t{2}", d.Pid, d.Ptitle, d.Price);
            }
        }
    }
}
