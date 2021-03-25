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
    class Menu
    {
        /// <summary>
        /// Global variable declaration
        /// </summary>
        SortingTimes sort;
        Storage store;
        UsernameGenerator username;

        /// <summary>
        /// Default constructor
        /// Starts the menu when called as well
        /// </summary>
        public Menu()
        {
            sort = new SortingTimes();
            store = new Storage();
            RunMenu();
        }


        /// <summary>
        /// Constructor
        /// Takes the SortingTimes and Storage objects as parameters and sets them to the global variables contained within this class
        /// </summary>
        /// <param name="sorting"></param>
        /// <param name="storage"></param>
        public Menu(SortingTimes sorting, Storage storage)
        {
            this.sort = sorting;
            this.store = storage;
            RunMenu();
        }


        /// <summary>
        /// Runs the main menu.
        /// Loops to keep user in the menu after it is called from the constructor. Can be called independently as well.
        /// 
        /// </summary>
        public void RunMenu()
        {

            // declares a local variable for the user input
            int userChoice;

            // infinite loop until break;
            while (true)
            {
                // Prints the main menu options for the user
                Console.WriteLine("\n*** Main Menu ***");
                Console.WriteLine("1. Storage Space\n2. Username\n3. Sorting\n4. Quit");
                

                /**
                 * try-catch incase the user does not enter a valid integer
                 */
                try
                {
                    // Get user input and try to parse as an integer
                    userChoice = int.Parse(Console.ReadLine());

                    // using if-statements for the main menu so that break can be used to get out of while loop
                    if (userChoice == 1)
                    {
                        // call the Sorting submenu
                        StorageMenu();
                    } else if(userChoice == 2)
                    {
                        // call the username submenu
                        UsernameMenu();
                    } else if(userChoice == 3)
                    {
                        //  call the sorting submenu
                        SortingMenu();
                    }
                    else if (userChoice == 4)
                    {
                        break;
                    } else
                    {
                        Console.WriteLine("That was not a valid option. Please try again\n");
                    }
                } catch(Exception ex)
                {
                    Console.WriteLine("Error: " + ex);
                }
            }
            Console.WriteLine("Quitting...");
        }


        /// <summary>
        /// Storage Submenu
        /// Another menu to be used when interacting with the Storage object.
        /// Keeps the main menu cleaner and less cluttered
        /// </summary>
        void StorageMenu()
        {
            // declares a local boolean and integer
            // boolean is for the menu loop and integer for user input
            bool loop = true;
            int userChoice;


            // submenu while loop
            while (loop)
            {
                /**
                 * try-catch in case the user doesn't enter a valid integer for the menu
                 */
                try
                {
                    Console.WriteLine("\n\n**** Storage Menu ****");
                    Console.WriteLine("1. Add to the storage list" + 
                        "\n2. Print the Storage List" + 
                        "\n3. Find the Largest Value is Storage List" + 
                        "\n4. Count the number of files in Storage List" +
                        "\n5. Total storage being used by items in Storage List" + 
                        "\n6. The average file size in Storage List" + 
                        "\n7 Back to main menu");

                    userChoice = int.Parse(Console.ReadLine());
                    switch (userChoice)
                    {
                        case 1:
                            store.AddToList();      // Calls the AddToList method in order to add items to the List until the user wants to stop
                            break;
                        case 2:
                            store.Print();          // Calls the Print method in order display everything in the List
                            break;
                        case 3:
                            Console.WriteLine("The largest number in the List is {0}", store.MaxInList());   // Calls the MaxInList() method and displays it in line
                            break;
                        case 4:
                            Console.WriteLine("The total number of files in the List is {0}", store.CountTheList());    // Calls the CountTheList() method and displays it in line
                            break;
                        case 5:
                            Console.WriteLine("The total storage being used is {0}", store.TotalMemory());      // Calls the TotalMemory() method and displays it in line
                            break;
                        case 6:
                            Console.WriteLine("The average file size is {0}", store.AverageMemory());       // Calls the AverageMemory() method and displays the return in line
                            break;
                        case 7:
                            loop = false;               // breaks the loops
                            break;
                        default:
                            Console.WriteLine("That was not a valid option. Please try again.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex);
                }
            }
            Console.WriteLine("Going back to main menu");

        }


        /// <summary>
        /// Sorting Submenu
        /// Another menu to be used when interacting with the SortingTimes object.
        /// Keeps the main menu cleaner and less cluttered.
        /// </summary>
        void SortingMenu()
        {
            try
            {
                bool loop = true;
                int userChoice;

                while (loop)
                {
                    Console.WriteLine("\n*** Sorting Submenu ***");
                    Console.WriteLine("1. Add items to the sorting list\n2. Print out the sorting list\n3. Sort the list\n4. Reverse sort the List\n5. Back to main menu");

                    userChoice = int.Parse(Console.ReadLine());
                    switch (userChoice)
                    {
                        case 1:
                            sort.AddToList();
                            break;
                        case 2:
                            sort.Print();
                            break;
                        case 3:
                            sort.RunSort();
                            break;
                        case 4:  
                            sort.RSort();
                            break;
                        case 5:
                            loop = false;
                            break;
                        default:
                            Console.WriteLine("That was not a valid option\nPlease try again.");
                            break;
                    }
                }
                Console.WriteLine("Heading back to main menu...");
            } catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }
        }


        /// <summary>
        /// Username Submenu
        /// Another menu to be used when interacting with the UsernameGenerator object.
        /// Keeps the main menu cleaner and less cluttered.
        /// This menu also initialises the UsernameGenerator object (username)
        /// 
        /// 
        /// </summary>
        void UsernameMenu()
        {
            // declares local variables
            // boolean for menu loop and integer for user input
            bool loop = true;
            int userChoice;

            try
            {
                while (loop)
                {
                    Console.WriteLine("\n*** Username Submenu ***");
                    Console.WriteLine("1. Enter a first and last name\n2. Update First name\n3. Update Last name\n4. Generate and display the username\n5. Back to main menu");

                    userChoice = int.Parse(Console.ReadLine());
                    string tempFirst, tempLast;

                    switch (userChoice)
                    {
                        case 1:
                            Console.WriteLine("Please enter the first nameq.");
                            tempFirst = Console.ReadLine();
                            Console.WriteLine("You entered {0} as the first name\nPlease enter the last name now.");
                            tempLast = Console.ReadLine();
                            username = new UsernameGenerator(tempFirst, tempLast);
                            break;
                        case 2:
                            tempFirst = Console.ReadLine();
                            Console.WriteLine("You've entered {0} as your first name.", tempFirst);
                            break;
                        case 3:
                            tempLast = Console.ReadLine();
                            Console.WriteLine("You've entered {0} as your last name", tempLast);
                            break;
                        case 4:
                            Console.WriteLine("Your username is: {0}", username.UserName );
                            break;
                    }
                }
                Console.WriteLine("Heading back to main menu...");
            } catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }
        }



    }
}
