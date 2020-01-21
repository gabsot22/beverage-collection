using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment1
{
    class BeverageCollection
    {
        // Variables / Backing fields
        private string _beverageType;

        public string BeverageType
        {
            get { return _beverageType; }
            set { _beverageType = value; }
        }

        
        // Constructors (always public)
        public BeverageCollection(string BeverageType)
        {
            this._beverageType = BeverageType;
           
        }

        public void Search(BeverageCollection[] beverageCollections)
        {
            string beverageName = Console.ReadLine();

            bool match = false;

            
            for (int i = 0; i < beverageCollections.Length; i++)
            {
                Console.WriteLine(beverageCollections[i]);
                //if (beverageName == beverageCollections[i])
                //{
                //    match = true;
                //}
            }
            if (match == true)
            {
                Console.WriteLine("Match has been found");
            }
        }

        public void Add(BeverageCollection[] beverageCollections)
        {

        }

    }
}


//        if (input == "1" && runOnce == false)
//            {
//                Console.WriteLine();
//                Console.WriteLine("Loaded beverage list");
//                Console.WriteLine();

//                runOnce = true;
//            }
//            else
//            {
//                Console.WriteLine("Already Loaded List");
//            }
    
//            if (input == "2" && runOnce == true)
//            {
//                Console.WriteLine();
//                Console.WriteLine("Printed list successfully");
//                Console.WriteLine();
//            }
//            else
//            {
//                Console.WriteLine("Must Load list once");
//            }

//            if (input == "3")
//            {
//                Console.WriteLine();
//                Console.WriteLine("Input beverage ITEM ID: ");
//                Console.WriteLine();

                
//            }
//            if (input == "4")
//            {

//            }
        
//    }
//}
