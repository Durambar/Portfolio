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
    class Program
    {

        /// <summary>
        /// Main method
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            SortingTimes sorting = new SortingTimes();
            Storage storage = new Storage();
            InitTest(sorting, storage);

            Menu menu = new Menu(sorting, storage);


            // Loop to confirm user wants to quit. Runs menu.RunMenu() if no is selected, quits the application if yes is selected
            bool beforeQuit = true;
            while (beforeQuit)
            {
                Console.WriteLine("Are you sure you want to Quit? Y/N");

                try
                {
                    char quitChoice = Char.Parse(Console.ReadLine().ToLower());
                    switch (quitChoice)
                    {
                        case 'y':
                            Console.WriteLine("Thank you for using this application\nGoodbye.");
                            System.Threading.Thread.Sleep(2000);
                            System.Environment.Exit(0);
                            break;
                        case 'n':
                            Console.WriteLine("Returning to main menu...\n\n");
                            menu.RunMenu();
                            break;
                        default:
                            Console.WriteLine("A valid choice wasn't made.\n");
                            break;

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex);
                }
            }
            Console.WriteLine("Something has gone wrong. Please contact the developer if you seen this message");
            Console.ReadKey();
        }

        /// <summary>
        /// Generates Test data and adds it to the objects
        /// </summary>
        /// <param name="sorting"></param>
        /// <param name="storage"></param>
        static void InitTest(SortingTimes sorting, Storage storage)
        {
            sorting.GenerateTestData();
            storage.GenerateTestData();   
        }
    }
}
