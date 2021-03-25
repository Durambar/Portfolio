using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeApp_V1
{
    //***********************************************
    //INSTRUCTIONS
    //Task 1: Comment the Course class
    //Task 2: Add the following read-only properties: 
    //           1. Full -//checks if course is full
    //           2. Empty -//checks if course is empty
    //           3. Count -  //gets the number of students enrolled on the course
    //Task 3: Add the following methods to this class:
    //      1. add student to course
    //      2. delete student from course
    //      3. find student by studentNumber and display student details
    //      4. display list of students enrolled on the course in alphabetical order
    //      
    //***********************************************


    public class Course
    {
        
        // constants
        private const int COURSE_CAPACITY = 24;

        // attributes
        private int courseNumber;
        private string courseName;
        private Student[] students;
        private int count;


        
        public int CourseNumber
        {
            get { return courseNumber; }
            set { courseNumber = value; }
        }

        public string CourseName
        {
            get { return courseName; }
            set { courseName = value; }
        }

        public Student[] Students
        {
            get { return students; }
            set { students = value; }
        }

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Course()
        {
            this.courseNumber = 0;
            this.courseName = "";
            this.students = new Student[COURSE_CAPACITY];
            count = -1;
        }

        /// <summary>
        /// Defasult Constructor
        /// </summary>
        /// <param name="courseNumber"></param>
        /// <param name="courseName"></param>
        public Course(int courseNumber, string courseName)
        {
            this.courseNumber = courseNumber;
            this.courseName = courseName;
            this.students = new Student[COURSE_CAPACITY];
            count = -1;
        }

        public Course(Student[] students)
        {
            this.students = students;
        }

        /// <summary>
        /// Method to check if the course is full
        /// </summary>
        /// <returns></returns>
        public bool IsFull()
        {
            // check if the array is the same or larger than course capacity
            if(count+1>=COURSE_CAPACITY)
            {
                return true;
            } else
            {
                return false;
            }
        }

        /// <summary>
        /// Method to check if class is empty
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            //check if the array is empty for the course
            if(count==-1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Get the number of students enrolled in the class
        /// </summary>
        /// <returns></returns>
        public int Count()
        {
            // need to add one as count is used for array
            return count+1;
        }

        /// <summary>
        /// Add student to the class
        /// </summary>
        /// <param name="student"></param>
       public void AddStudent(Student student)
        {
            // Adds the new student at the end of the array
            students[count+1] = student;
            count++;
        }

        /// <summary>
        /// Delete student from the course
        /// </summary>
        /// <param name="test"></param>
       public void RemoveStudent(Student test)
        {
           int pos = 0;
           for (pos =0;  pos <= count; pos++){
                // finds position of the desired student
                if (students[pos].Equals(test))
                {
                    // if statement to remove the final item in the array
                    // causes duplication if not present
                    if (pos == count)
                    {
                        students[pos] = null;
                    }
                    else
                    {
                        // moves each item down one within the array, overwriting the one that's getting deleted
                        int i;
                        for (i = pos; i < count; i++)
                        {
                            students[i] = students[i + 1];
                        }
                    }
                }
                
            }
           // takes one away from the current count
            count--;
        }

        /// <summary>
        /// Method to find a student.
        /// Uses a Linear search
        /// </summary>
        /// <param name="Id"></param>
        public void FindStudentByStudentNumber(int Id)
        {
            int i = 0;
            for (i = 0; i < count; i++)
            {
                if (students[i].StudentNumber == Id)
                {
                    students[i].StudentInformation();
                }
            }
        }


        /// <summary>
        /// Method to display all students, sorted based on their surnames using SortStudents()
        /// </summary>
       public void DisplayStudents()
        {
            SortStudents(students);
            int i = 0;
            for (i = 0; i < count + 1; i++)
            {
                students[i].StudentInformation();
            }
        }


        /// <summary>
        ///  Method to sort the students by their surnames
        /// </summary>
        /// <param name="data"></param>
        public void SortStudents(Student[] data)
        {
            int i, j;
            //string temp, temp1;
            //char charTemp, charTemp1;
            int charNum, charNum1;
            int N = count+1;

           
                for (j = N - 1; j > 0; j--)
                {
                for (i = 0; i < j; i++)
                {
                    //temp = data[i].LastName;
                    //temp1 = data[i + 1].LastName;
                    //charTemp = data[i].LastName[0];
                    //charTemp1 = data[i + 1].LastName[0];
                    charNum = data[i].LastName[0];
                    charNum1 = data[i + 1].LastName[0];
                        if (charNum > charNum1)
                        {
                            exchange(data, i, i + 1);
                        }
                    }
                }
        }

        /// <summary>
        ///  Used to move students within the array, called by the sort method
        /// </summary>
        /// <param name="data"></param>
        /// <param name="m"></param>
        /// <param name="n"></param>
        public void exchange(Student[] data, int m, int n)
        {
            Student temporary;

            temporary = data[m];
            data[m] = data[n];
            data[n] = temporary;
        }
    }
}
