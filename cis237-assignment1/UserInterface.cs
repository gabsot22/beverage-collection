/* Gabriel Soto
 * CIS 237 MW 6:00-8:15pm
 * 1/22/20
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment1
{
    class UserInterface
    {
        // Variable for only loading list once
        bool runOnce = false;

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

            
            if (input == "1" && runOnce == false )
            {
                Console.WriteLine();
                Console.WriteLine("Loaded beverage list");
                Console.WriteLine();

                // Change boolean to true so you cant load list again
                runOnce = true; 
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Already Loaded List");
                Console.WriteLine();
            }
            
            if (input == "2")
            {
                Console.WriteLine();
                Console.WriteLine("Printed list successfully");
                Console.WriteLine();
            }

            if (input == "3")
            {
                Console.WriteLine();
                Console.WriteLine("Input beverage info exactly how it is displayed in the list ");
                Console.WriteLine();

                


            }
            if (input == "4")
            {
                Console.WriteLine();
                Console.WriteLine("Add a beverage! ");
                Console.WriteLine();
            }

                // Return the input
                return Int32.Parse(input);
        }

        // Method for outputting array
        public void OptionTwo(string outputString)
        {
            Console.WriteLine(outputString);
        }

        // Menu
        private void PrintMenu()
        {
            Console.WriteLine("Select one of the options :)");
            Console.WriteLine("1: Load beverage list");
            Console.WriteLine("2: Print list");
            Console.WriteLine("3: Search by item ID");
            Console.WriteLine("4: Add new beverage");
            Console.WriteLine("5: Exit");
            Console.WriteLine();
        }

        // Error Message
        private void PrintErrorMessage()
        {
            Console.WriteLine("That is not one of the options");
            Console.WriteLine("Select an valid option");
            Console.WriteLine();
        }

    }


}
