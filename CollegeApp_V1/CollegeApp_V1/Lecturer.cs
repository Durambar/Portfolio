using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeApp_V1
{
    /// <summary>
    /// Subclass of Person
    /// </summary>
  public class Lecturer:Person
  {

        //attributes
        private int lecturerId;
        


        //properties
        public int LecturerId
        {
            get { return lecturerId; }
            set { lecturerId = value; }
        }

       
        /// <summary>
        /// Default Constructor
        /// </summary>
        public Lecturer():base()
        {
            this.lecturerId = 0;

        }


        /// <summary>
        /// Overloaded Constructor
        /// </summary>
        /// <param name="lecturerId"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="street"></param>
        /// <param name="city"></param>
        /// <param name="postcode"></param>
        public Lecturer(int lecturerId, string firstName,
            string lastName,string street, string city, string postcode):
            base(firstName, lastName, street, city, postcode)
        {
            this.lecturerId = lecturerId;
        }


    }
}
