using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeApp_V1
{
    public class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
      public  static void Main(string[] args)
        {
            CourseDriver();

            Console.ReadKey();
        }




        //static driver method to test the course class
        /// <summary>
        /// 
        /// </summary>
        public static void CourseDriver()
        {


            Course course = new Course();

            Student st1 = new Student(123, "Brian","Smith","1 Happy Street","Glasgow","G1 5DF" );
            Student st2 = new Student(124, "Gery", "Carlton", "2 Gilmour Street", "Glasgow", "G1 5DF");
            Student st3 = new Student(125, "Olivia", "Wilson", "3 High Street", "Glasgow", "G1 5DF");
            Student st4 = new Student(126, "Alex", "Tait", "4 Fair Street", "Glasgow", "G1 5DF");
            Student st5 = new Student(127, "James", "Kelly", "5 Law Street", "Glasgow", "G1 5DF");

            course.AddStudent(st1);
            course.AddStudent(st2);
            course.FindStudentByStudentNumber(123);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("There are {0} students enrolled on the course", course.Count());
            course.DisplayStudents();
            course.AddStudent(st3);
            course.AddStudent(st4);
            course.AddStudent(st5);
            Console.WriteLine("***************************************************************************");
            course.DisplayStudents();
            course.RemoveStudent(st3);
            Console.WriteLine("***************************************************************************");
           Console.WriteLine("There are {0} students enrolled on the course", course.Count());
            course.DisplayStudents();


        }
    }
}
