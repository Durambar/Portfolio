using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
///     <author>
///         Michael C. Jackson
///     </author>
///     <version>
///         19/02/21
///     </version>
/// </summary>

namespace Assessment
{
    class UsernameGenerator
    {
        private string firstName, lastName, userName;


        /** 
         *  Properties with validation for setting values
         */
        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (value.Length > 2)
                {
                    this.firstName = value;
                } else
                {
                    throw new ArgumentException(String.Format("\"{0}\" is not long enough to be used as a first name", value));
                }
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (value.Length > 2)
                {
                    this.lastName = value;
                }
                else
                {
                    throw new ArgumentException(String.Format("\"{0}\" is not long enough to be used as a last name", value));
                }
            }
        }


        /// <summary>
        /// I've prevented the user from being able to set their own username
        /// It will run the GenerateUsername() method if firstname and lastname have both been set
        /// </summary>
        public string UserName
        {
            get { return this.userName; }
            set
            {
                throw new ArgumentException(String.Format("You cannot set the username to {0}, as this program is designed to generate the username for you"));
            }
        }


        /// <summary>
        /// Default Constructor
        /// </summary>
        public UsernameGenerator()
        {
            this.FirstName = "";
            this.LastName = "";
        }

        /// <summary>
        /// Constructor that will also generate the username when the object is created.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        public UsernameGenerator(string name, string surname)
        {
            this.FirstName = name;
            this.LastName = surname;
            GenerateUsername();
        }

        /// <summary>
        /// Method to generate the username 
        /// - Might need to adjust this -
        /// </summary>
        private void GenerateUsername()
        {
            userName = FirstName.Substring(0, 1) + LastName;
            Console.WriteLine("Username has been generated and set to {0}", UserName);
        }
    }
}
