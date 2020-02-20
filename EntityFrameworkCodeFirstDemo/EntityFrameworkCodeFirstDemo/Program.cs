using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodeFirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // InsertData();
            // Search();
            // Update();
               Delete();
               DisplayData();
            




           Console.ReadKey();
        }

        private static void Delete()
        {
            EmployeeContext ess = new EmployeeContext();
            Console.WriteLine("Enter Id To Update Data:");
            int id = int.Parse(Console.ReadLine());
            ess.Employees.Remove(ess.Employees.Find(id));
            ess.SaveChanges();
            Console.WriteLine("Deleted Successfully");

        }

        private static void Update()
        {
            EmployeeContext es = new EmployeeContext();
            Console.WriteLine("Enter Id To Update Data:");
            int id=int.Parse(Console.ReadLine());
            Employee result = es.Employees.SingleOrDefault(a=>a.Eid==id);
            result.Ename = "Dipika";
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

        private static void DisplayData()
        {
            EmployeeContext es = new EmployeeContext();
            var employees = es.Employees;
            foreach (var emp in employees)
            {
                Console.WriteLine("{0}     {1}              {2}             {3}", emp.Eid, emp.Ename, emp.Designation, emp.Salary);
            }
        }

        private static void InsertData()
        {
            EmployeeContext ect = new EmployeeContext();
            Console.WriteLine("Enter Employee Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Employee Designation");
            string des = Console.ReadLine();
            Console.WriteLine("Enter Employee Salary");
            double sal = int.Parse(Console.ReadLine());

            ect.Employees.Add(new Employee 
            {
                Ename = name, 
                Designation = des,
                Salary = sal 
            });
            ect.SaveChanges();
        }
    }
}
