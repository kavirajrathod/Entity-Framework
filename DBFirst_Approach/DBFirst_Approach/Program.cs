using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFirst_Approach
{
    class Program
    {
        static EmployeeDBEntities mdb=new EmployeeDBEntities();
        static void Main(string[] args)
        {
            InsertData();
            Show();
            

            Console.ReadKey();
        }

        private static void InsertData()
        {
            
            Console.WriteLine("enter student ID");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("enter student Name");
            string name = Console.ReadLine();

            Console.WriteLine("enter student Branch");
            string branch = Console.ReadLine();

            Console.WriteLine("enter Mobile Number");
            int mobile_number = int.Parse(Console.ReadLine());

            var Student = new Student();
            {
                Student.Stud_id = id;
                Student.Stud_name = name;
                Student.Branch = branch;
                Student.Mo_number = mobile_number;
            
            }
            mdb.Students.Add(Student);
            mdb.SaveChanges();
            

            Console.WriteLine("enter Course ID");
            string cid = Console.ReadLine();

            Console.WriteLine("enter Course Title");
            string title= Console.ReadLine();

            Console.WriteLine("enter Start Date");
            string stdate = Console.ReadLine();

            Console.WriteLine("enter Fees");
            int fee = int.Parse(Console.ReadLine());

            var Course = new Course();
            {
                Course.Course_id = cid;
                Course.Course_title = title;
                Course.StartDate = stdate;
                Course.Fees = fee;

            }
            mdb.Courses.Add(Course);
            mdb.SaveChanges();

        }

        private static void Show()
        {

            Console.WriteLine("Course Table:");
            var courses = mdb.Courses;
            foreach (var c in courses)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", c.Course_id, c.Course_title, c.StartDate, c.Fees);
            }
            Console.WriteLine();


            Console.WriteLine("Student Table:\n");
            var students = mdb.Students;
            foreach (var s in students)
            {

                Console.WriteLine("{0}\t{1}\t{2}\t{3}", s.Stud_id, s.Stud_name, s.Branch, s.Mo_number);
            }

        }
    }
}
