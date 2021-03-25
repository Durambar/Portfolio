using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeApp_V1
{
    //superclass
    public class Person
    {
        //attributes
        private string firstName;
        private string lastName;
        private string street;
        private string city;
        private string postcode;

        //properties
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string Street
        {
            get { return street; }
            set { street = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string Postcode
        {
            get { return postcode; }
            set { postcode = value; }
        }

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Person()
        {
            
            this.firstName = "Joe";
            this.lastName = "Black";
            this.street = "";
            this.city = "";
            this.postcode = "";
        }

        /// <summary>
        /// Overloaded Constuctor
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="street"></param>
        /// <param name="city"></param>
        /// <param name="postcode"></param>
        public Person(string firstName, string lastName, 
            string street, string city, string postcode )
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.city = city;
            this.street = street;
            this.postcode = postcode;
        }


    }
}
