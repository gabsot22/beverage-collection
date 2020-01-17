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

            

            // Get input from the user
            int choice = ui.UserInput();

            // While the choice they selected is not 5, continue to do work
            while (choice != 5)
            {

            }

            // Re-display for input
            choice = ui.UserInput();
        }
    }
}
