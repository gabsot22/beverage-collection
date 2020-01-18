/* Gabriel Soto
 * CIS 237
 * 1/22/20
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Making a new instance of UI class

            UserInterface ui = new UserInterface();

            
            
            // Making a new instance of the Beverage class
            Beverage beverageList = new Beverage("39171", "1221 Cabernet Cuvee", "6 / 750 ml", 70.1m, "TRUE");

            // Makes an array to hold instances in Beverage class
            Beverage[] beverages = new Beverage[3942];

            // Makes an array to hold instances in BeverageCollection class
            BeverageCollection[] beveragesCollection = new BeverageCollection[3942];


            // Get input from the user
            int choice = ui.UserInput();

            // While the choice they selected is not 5, continue to do work
            while (choice != 5)
            {
                // Load the list
                if (choice == 1)
                {
                    
                    // Make a string for the path to the csv file
                    string pathToCsv = "../../../datafiles/beverage_list.csv"; // starts at bin debug. Each .. goes back one folder

                    // Make instance of CSVProcessor
                    CSVProcessor csvProcessor = new CSVProcessor();

                    // Call the ImportCSV method sending over the path and the array to store the read in records to.
                    csvProcessor.ImportCsv(pathToCsv, beverages);

                    choice = ui.UserInput();
                }
                // Print out list
                if (choice == 2)
                {
                    // Create a string that can be concated t
                    string outputString = "";

                    //// Print out the beverages in an array
                    foreach (Beverage beverage in beverages)
                    {
                        // Check to ensure there is a beverage object to be able to access properties on
                        if (beverage != null)
                        {
                            outputString += beverage.ToString() + Environment.NewLine;
                        }
                    }

                    ui.OptionTwo(outputString);

                    Console.WriteLine(); // Empty space

                    choice = ui.UserInput();
                }
                // Search for beverage ID
                if (choice == 3)
                {
                    // Making a new instance of the BeverageCollection class
                    BeverageCollection bevCollection = new BeverageCollection();

                    

                }
                // Add a new beverage
                if (choice == 4)
                {

                }
            }

            // Re-display for input
            choice = ui.UserInput();
        }
    }
}
