using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeApp_V1
{
    public class Student:Person
    {
        //attributes
        private int studentNumber;
        private Grades grade;


        //properties
        public int StudentNumber
        {
            get { return studentNumber; }
            set { studentNumber = value; }
        }

       

        public Grades Grade
        {
            get { return grade; }
            set { grade = value; }
        }

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Student():base()
        {
            this.studentNumber = 0;
            this.grade = Grades.F;

        }

        /// <summary>
        /// Overloaded Constructor
        /// </summary>
        /// <param name="studentNumber"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="street"></param>
        /// <param name="city"></param>
        /// <param name="postcode"></param>
        /// <param name="grade"></param>
        public Student(int studentNumber, string firstName,
            string lastName, string street, string city, string postcode, Grades grade)
            :base(firstName, lastName, street, city,postcode)
        {
            this.studentNumber = studentNumber;
            this.grade = grade;
            
        }

        /// <summary>
        /// Overloaded Constructor
        /// </summary>
        /// <param name="studentNumber"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="street"></param>
        /// <param name="city"></param>
        /// <param name="postcode"></param>
        public Student(int studentNumber, string firstName, string lastName, string street, string city, string postcode) : base(firstName, lastName, street, city, postcode)
        {
            this.studentNumber = studentNumber;
            
        }

        /// <summary>
        /// Method to set the grade
        /// </summary>
        /// <param name="grade"></param>
        public void TakeExam(Grades grade)
        {
            this.grade = grade;
        }

        /// <summary>
        /// Method to display the students information
        /// </summary>
        public void StudentInformation()
        {
            Console.WriteLine("Student Number:{0} , Student Name: {1} {2} Student Address:{3} {4} {5} ",
                studentNumber, FirstName, LastName, Street, City, Postcode);
        }

    }//end of class

    public enum Grades
    {
        A, B, C, D, F
    }



}//end of Namespace
