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

            
            Beverage beverageList = new Beverage();
            

            // 
            int choice = ui.UserInput();

            // While the choice they selected is not 5, continue to do work
            while (choice != 5)
            {
                // See if the input they sent is equal to 1
                if (choice == 1)
                {
                    BeverageCollection bevCollection = new BeverageCollection();
                }
            }

            // Re-display for input
            ui.UserInput();
        }
    }
}
