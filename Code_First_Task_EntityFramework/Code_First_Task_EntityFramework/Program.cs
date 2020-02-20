using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_First_Task_EntityFramework
{
    class Program
    {
        static Context c = new Context();
        
        static void Main(string[] args)
        {

             InsertData();
            // Search();
            // Update();
            // Delete();
            DisplayData();





            Console.ReadKey();
        }
        /*
                private static void Delete()
                {

                    Console.WriteLine("Enter Id To Update Data:");
                    int id = int.Parse(Console.ReadLine());
                    c.Customers.Remove(c.Customers.Find(id));
                    c.SaveChanges();
                    Console.WriteLine("Deleted Successfully");

                }

                private static void Update()
                {

                    Console.WriteLine("Enter Id To Update Data:");
                    int id = int.Parse(Console.ReadLine());
                    Context result = c.Customers.SingleOrDefault(a => a.Cust_id == id);
                    result.Cust_name = "Dipika";
                    result.Designation = "Developer";
                    result.Salary = 200000;
                    es.SaveChanges();
                }

                private static void Search()
                {
                    EmployeeContext ese = new EmployeeContext();
                    Console.WriteLine("Enter ID:");
                    int eid = int.Parse(Console.ReadLine());
                    Employee emp = (from e in ese.Employees
                                    where e.Eid == eid
                                    select e).First();

                    Console.WriteLine("{0}  {1}        {2}        {3}", emp.Eid, emp.Ename, emp.Designation, emp.Salary);
                }
        */
        

           private static void InsertData()
               {                                  
                   Console.WriteLine("Enter Customer ID");
                   int cust_id = int.Parse(Console.ReadLine());
                   Console.WriteLine("Enter Customer Name");
                   string cust_name = Console.ReadLine();
                   Console.WriteLine("Enter Customer  City");
                   string city = Console.ReadLine();

                   c.Customers.Add(new Customer
                   {
                       Cust_id = cust_id,
                       Cust_name = cust_name,
                       City = city
                   });
                   c.SaveChanges();
               }

        private static void DisplayData()
        {

            var Customers = c.Customers;
            foreach (var cust in Customers)
            {
                Console.WriteLine("{0}     {1}       {2}", cust.Cust_id, cust.Cust_name, cust.City);
            }
        }



        private static void InsertDataP()
        {
            Console.WriteLine("Enter Product ID");
            int p_id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Product Name");
            string p_name = Console.ReadLine();
            Console.WriteLine("Enter Quantity");
            string q = Console.ReadLine();
            Console.WriteLine("Enter Price");
            string q = Console.ReadLine();

            c.Customers.Add(new Customer
            {
                Cust_id = cust_id,
                Cust_name = cust_name,
                City = city
            });
            c.SaveChanges();
        }

        private static void DisplayData()
        {

            var Customers = c.Customers;
            foreach (var cust in Customers)
            {
                Console.WriteLine("{0}     {1}       {2}", cust.Cust_id, cust.Cust_name, cust.City);
            }
        }
    }
}

