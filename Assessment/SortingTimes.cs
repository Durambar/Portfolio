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
    class SortingTimes
    {
        private List<double> times;
        public int count = 0;


        // Property for the List - setting should not be used in this version. It could be used for testing purposes or if the program was given persistance
        public List<double> Times
        {
            get { return this.times; }
            set
            {
                //Console.WriteLine("This function should be used for testing purposes only");
                this.times = value;
            }
        }

        // Default constructor
        public SortingTimes()
        {
            times = new List<double>();
        }

        // Method to print out all the values from the list
        public void Print()
        {
            Console.WriteLine("Printing data");
            foreach(double time in Times)
            {
                Console.WriteLine("Value is {0}", time);
            }
        }


        /// <summary>
        /// Method to easily add test data - data taken from assessment brief
        /// </summary>
        public void GenerateTestData()
        {
            /*double[] testData = new double[]
            {
                21.23, 23.45,23.71,22.22,24.12,21.23,21.23,21.45,26.52,29.21,20.01,20.00,24.29,27.64,24.85,29.99,21.11,21.22,21.33,21.44,21.55,21.66,21.77,21.88,21.99,22.22,22.33,22.44,22.55,22.66,22.77,22.88,22.99,30.01,50.22,50.68,50.69,43.65,48.31,78.60,11.11,12.98,25.65,65.25,28.28,94.21,96.35,34,36.45,0.12,54.85
            };
            */

            Times.Add(21.23);
            Times.Add(23.45);
            Times.Add(23.71);
            Times.Add(22.22);
            Times.Add(24.12);
            Times.Add(21.23);
            Times.Add(21.23);
            Times.Add(21.45);
            

        /*foreach(double data in testData)
            {
                Times.Add(data);
            }
        */
            Console.WriteLine("Test data generated");
        }


        /// <summary>
        /// 
        /// </summary>
        public void AddToList()
        {
            // Ask the user for input
            Console.WriteLine("Please enter each value on a seperate line, and then enter -1 if you are finished");
            // declare userInput and set it to 0
            double userInput = 0;
            // While loop that will keep going until -1 is entered
            while (userInput != -1)
            {
                // Try-catch since I'm parsing data, in case the user put's in a non integer
                try
                {
                    // get user input
                    userInput = double.Parse(Console.ReadLine());

                    // validations
                    if (userInput > 0) // the value entered is acceptable
                    {
                        Times.Add(userInput);
                        Console.WriteLine("{0} was added to the List", userInput);

                    }
                    else if (userInput == -1) // to quit
                    {
                        Console.WriteLine("Thank you, you're numbers have been added to the List successfully");
                    }
                    else if (userInput < -1) // invalid value - the value shouldn't be negative
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
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <param name="lower"></param>
        /// <param name="upper"></param>
        private async Task DoubleListQuickSort(List<double> data, int lower, int upper)
        {
            int i, j;
            double x;

            i = lower;
            j = upper;

            x = data[(lower + upper) / 2];

            while (true)    //Run until break
            {
                while (data[i] < x)
                {
                    i++;
                }
                while (x < data[j]) 
                { 
                    j--; 
                }
                if(i <= j)                          
                {
                    ExchangeDouble(data, i, j);
                    i++;
                    j--;
                }
                if (i > j)
                    break;
            }

            if (lower < j)
                await DoubleListQuickSort(data, lower, j);

            if (i < upper)
                await DoubleListQuickSort(data, i, upper);
        }


        /// <summary>
        /// Reverse sorting using quicksort
        /// async for effeciency
        /// </summary>
        /// <param name="data"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        private async Task ReverseDoubleListQuickSort(List<double> data, int left, int right)
        {
            int i, j;
            double pivot;

            i = left;
            j = right;

            pivot = data[(left + right) / 2];

            while (true)    //Run until break
            {
                //if (i < 0 || i > Times.Count - 1)
                //break;


                while (data[i] > pivot)
                    i++;
                while (pivot > data[j])
                    j--;
                if (i <= j)
                {
                    ExchangeDouble(data, i, j);
                    i++;
                    j--;
                }
                if (i > j)
                    break;
            }

            if (left < j)
                await ReverseDoubleListQuickSort(data, left, j);

            if (i > right)
                await ReverseDoubleListQuickSort(data, i, right);
        }

        /// <summary>
        /// Method to run the reverse sort method
        /// </summary>
        public async Task RSort()
        {
            await ReverseDoubleListQuickSort(Times, 0, Times.Count - 1);
        }


        /// <summary>
        /// Runs the sorting method
        /// </summary>
        public async Task RunSort()
        {
            await DoubleListQuickSort(Times, 0, Times.Count - 1);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <param name="m"></param>
        /// <param name="n"></param>
        private void ExchangeDouble(List<double> data, int m, int n)
        {
            double temp;
            temp = data[m];
            data[m] = data[n];
            data[n] = temp;
        }

    }
}
