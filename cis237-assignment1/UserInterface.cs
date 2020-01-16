using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment1
{
    class UserInterface
    {
        // No Variables
        // No Properties
        // No Constructors

        // Methods
        public int UserInput()
        {
            // Prints out a menu for the user
            PrintMenu();
            
            // Get input from user
            string input = Console.ReadLine();
            

            while (input != "1" && input != "2" && input != "3" && input != "4" && input != "5")
            {
                
                // Print Error Message
                PrintErrorMessage();

                // Re-displays the menu
                PrintMenu();

                // Gets the input from the user again
                input = Console.ReadLine();
            }
            
            

            return Int32.Parse(input);
        }

        public void OptionTwo(string optionTwoString)
        {
            Console.WriteLine(optionTwoString);
        }

        private void PrintMenu()
        {
            Console.WriteLine("Select one of the options :)");
            Console.WriteLine("1: Load beverage list");
            Console.WriteLine("2: Print list");
            Console.WriteLine("3: Search by item ID");
            Console.WriteLine("4: Add new beverage");
            Console.WriteLine("5: Exit");
        }

        private void PrintErrorMessage()
        {
            Console.WriteLine("That is not one of the options");
            Console.WriteLine("Select an valid option");
            Console.WriteLine();
        }

    }

    
}
