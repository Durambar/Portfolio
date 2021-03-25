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
    class Storage
    {
        private List<int> fileSizes;


        // Property for the list - set should only be used for testing or if persistance is implemented
        public List<int> FileSizes
        {
            get { return this.fileSizes; }

            // set will only be used for testing purposes
            // there is a method for adding to the list which will also validate the data
            set { this.fileSizes = value; }
        }


        // default constructor
        public Storage()
        {
            fileSizes = new List<int>();
        }



        /// <summary>
        /// Method to add to the list with validation to ensure the value is positive
        /// AddToList() contains a loop that will keep going until -1 is entered.
        /// Will inform the user if a non-valid number is entered and not add it to the list
        /// </summary>
        public void AddToList()
        {
            // Ask the user for input
            Console.WriteLine("Please enter each value on a seperate line, and then enter -1 if you are finished");
            // declare userInput and set it to 0
            int userInput = 0;
            // While loop that will keep going until -1 is entered
            while (userInput != -1)
            {
                // Try-catch since I'm parsing data, in case the user put's in a non integer
                try
                {
                    // get user input
                    userInput = int.Parse(Console.ReadLine());

                    // validations
                    if (userInput > 0) // the value entered is acceptable
                    {
                        FileSizes.Add(userInput);
                        Console.WriteLine("{0} was added to the List", userInput);

                    } else if (userInput == -1) // to quit
                    {
                        Console.WriteLine("Thank you, you're numbers have been added to the List successfully");
                    } else if (userInput < -1) // invalid value - the value shouldn't be negative
                    {
                        Console.WriteLine("You have no entered a valid number, please try again");
                    } 
                }
                catch (Exception ex) // catch the exceptions should it occur - most likely a parsing error
                {
                    // inform the user that an error has occured
                    Console.WriteLine("Error: " + ex);
                }
            }
        }

        /// <summary>
        /// Method top find the max value within the List
        /// Could have used return FileSizes.Max(); but broke it down for assessment purposess
        /// </summary>
        /// <returns></returns>
        public int MaxInList()
        {
            // set initial value as -1, so the user would know if nothing was in the list, since the file sizes are in MB rounded to nearest, it is possible a value might be zero
            int maxValue = -1;
            if (FileSizes != null)
            {
                maxValue = FileSizes[0];
                foreach (int file in FileSizes)
                {
                    if(file > maxValue)
                    {
                        maxValue = file;
                    }

                }
            }
            return maxValue;
        }


        /// <summary>
        /// Returns the total number of items in the List
        /// </summary>
        /// <returns></returns>
        public int CountTheList()
        {
            return FileSizes.Count + 1;
        }


        /// <summary>
        /// Method to add up to find the total storage value from the values within the List
        /// </summary>
        /// <returns></returns>
        public int TotalMemory()
        {
            int total = 0;
            foreach(int file in FileSizes)
            {
                total += file;
            }
            return total;
        }


        /// <summary>
        /// Method to calculate the Average file size in the list, calls TotalMemory() to reduce repetition
        /// </summary>
        /// <returns></returns>
        public int AverageMemory()
        {
            int average = TotalMemory() / (FileSizes.Count + 1);
            return average;
        }


        /// <summary>
        /// Method to print out all the values in the list on a new line
        /// </summary>
        public void Print()
        {
            Console.WriteLine("Printing data");
            foreach (int item in FileSizes)
            {
                Console.WriteLine("Value is {0}", item);
            }
        }


        /// <summary>
        /// Method to generate test data based on the assessment brief
        /// </summary>
        public void GenerateTestData()
        {
            FileSizes.Add(232);
            FileSizes.Add(241);
            FileSizes.Add(324);
            FileSizes.Add(216);
            FileSizes.Add(221);
            FileSizes.Add(298);
            FileSizes.Add(334);
            FileSizes.Add(212);
            FileSizes.Add(235);
            FileSizes.Add(324);
            FileSizes.Add(264);
            FileSizes.Add(141);
        }

    }
}
