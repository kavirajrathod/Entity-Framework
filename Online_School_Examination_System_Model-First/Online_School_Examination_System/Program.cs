using System;

namespace Online_School_Examination_System
{
    class Program
    {
        static ExaminationSystemEntities db = new ExaminationSystemEntities();
        static void Main(string[] args)
        {
            Insert();
            Display();
            Console.ReadKey();

        }

        private static void Insert()
        {
            
            Console.WriteLine("Insert Data in Center Table");

            Console.WriteLine("Enter Center Code");
            string Ccode = Console.ReadLine();
            Console.WriteLine("Enter Center Name");
            string cname = Console.ReadLine();
            Console.WriteLine("Enter Center Address");
            string cadd = Console.ReadLine();

           
            db.Centers.Add(new Center
            {
                center_code = Ccode,
                center_name = cname,
                center_address = cadd

            });
            db.SaveChanges();

            Console.WriteLine("Insert Data in Student Table");

            Console.WriteLine("Enter Seat Number");
            string snum = Console.ReadLine();
            Console.WriteLine("Enter Student name");
            string stdname = Console.ReadLine();
            Console.WriteLine("Enter Exam Date");
            DateTime exmdate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter Examcode");
            string exmcode = Console.ReadLine();
            Console.WriteLine("Enter Center Code");
            string ccode = Console.ReadLine();

            db.Students.Add(new Student
            {
                seat_number = snum,
                student_name = stdname,
                exam_date = exmdate,
                exam_code = exmcode,
                center_code = ccode
            });
            db.SaveChanges();


            Console.WriteLine("Insert Data in ExamDetails Table");

                        Console.WriteLine("Enter Exam Code");
                        string Ecode = Console.ReadLine();
                        Console.WriteLine("Enter Exam Name");
                        string ename = Console.ReadLine();
                        Console.WriteLine("Enter Exam Date");
                        DateTime edate = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine("Enter Total Marks");
                        int tmarks = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Passing Marks");
                        int pmarks = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter TimeDuration");
                        TimeSpan td = TimeSpan.Parse(Console.ReadLine());

                        
                        db.ExamDetails.Add(new ExamDetail
                            {
                            exam_code = Ecode,
                            exam_name = ename,
                            exam_date = edate,
                            total_marks = tmarks,
                            passing_marks = pmarks,
                            time_duration = td
                        });
                        db.SaveChanges();
                       

                        Console.WriteLine("Insert Data in Result Table");
                        Console.WriteLine("Enter Seat Number");
                        string sitNumber = Console.ReadLine();
                        Console.WriteLine("Enter Obtained Marks");
                        int mobt =int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Total Marks");
                        int totalmarks = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Percentages");
                        float Per = float.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Enter Result");
                        string res = Console.ReadLine();

                        db.Results.Add(new Result
                        {
                            seat_number = sitNumber,
                            marks_obtained = mobt,
                            total_marks = totalmarks,
                            percentage = Per,
                            result1 = res
                        });
                        db.SaveChanges();
                        
        }


        public static void Display()
        {
            Console.WriteLine("::Student::\n");
            var students = db.Students;
            foreach (var c in students)
            {
                Console.WriteLine("Seat Number: {0}\nStudent Name: {1}\nExam Date: {2}\nExam Code: {3}\nCenter Code: {4}", 
                    c.seat_number,
                    c.student_name,
                    c.exam_date, 
                    c.exam_code,
                    c.center_code);
            }
            Console.WriteLine();


            Console.WriteLine("::Center::\n");
            var centers = db.Centers;
            foreach (var d in centers)
            {
                Console.WriteLine("Center Code: {0}\nCenter Name: {1}\nCenter Address: {2}",
                    d.center_code,
                    d.center_name,
                    d.center_address);
            }
            Console.WriteLine();


            Console.WriteLine("::ExamDetails::\n");
            var examDetails = db.ExamDetails;
            foreach (var d in examDetails)
            {
                Console.WriteLine("Exam Code: {0}\nExam Name: {1}\nExam Date: {2}\nTotal Marks: {3}\nPassing Mark: {4}\nTimeDuration: {5}",
                    d.exam_code,
                    d.exam_name,
                    d.exam_date,
                    d.total_marks, 
                    d.passing_marks,
                    d.time_duration);
            }
            Console.WriteLine();

            Console.WriteLine("::Result::\n");
            var results = db.Results;
            foreach (var d in results)
            {
                Console.WriteLine("Seat Number: {0}\nMarksObtained: {1}\nTotal Marks: {2}\nPercentage: {3}\nResult: {4}",
                    d.seat_number,
                    d.marks_obtained,
                    d.total_marks,
                    d.percentage,
                    d.result1);
                Console.WriteLine();

            }

        }
    }
}
