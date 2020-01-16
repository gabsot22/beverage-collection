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
            // Makes an array to hold instances in Beverage class
            Beverage[] beverages = new Beverage[3942];

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
            if (input == "1")
            {
                // Make a string for the path to the csv file
                string pathToCsv = "../../../datafiles/beverage_list"; // starts at bin debug. Each .. goes back one folder

                // Make instance of CSVProcessor
                CSVProcessor csvProcessor = new CSVProcessor();

                // Call the ImportCSV method sending over the path and the array to store the read in records to.
                csvProcessor.ImportCsv(pathToCsv, beverages);

                Console.WriteLine("Loaded beverage list");




            }
            if (input == "2")
            {
                // Create a string that can be concated t
                string outputString = "";


                // Print out the beverages in an array
                foreach (Beverage beverage in beverages)
                {
                    // Check to ensure there is a beverage object to be able to access properties on
                    if (beverage != null)
                    {
                        outputString += beverage.ToString() + Environment.NewLine;
                    }
                }
            }

            return Int32.Parse(input);
        }

        public void OptionTwo(string outputString)
        {
            Console.WriteLine(outputString);
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
