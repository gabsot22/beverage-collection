
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace cis237_assignment1
{
    class CSVProcessor
    {
        // Class for reading CSV file and creating the beverageItemCollection list


        // Variables / Backing fields
        private int _beverageID;
        private string _beverageName;
        private decimal _beveragePrice;
        private string _beveragePack;
        private string _beverageActiveTF;

        // Properties (to use in Program.cs)
        public int BeverageID
        {
            get { return _beverageID; }
            set { _beverageID = value; }
        }

        public string BeverageName
        {
            get { return _beverageName; }
            set { _beverageName = value; }
        }

        public string BeveragePack
        {
            get { return _beveragePack; }
            set { _beveragePack = value; }
        }
        public decimal BeveragePrice
        {
            get { return _beveragePrice; }
            set { _beveragePrice = value; }
        }

        public string BeverageActiveTF
        {
            get { return _beverageActiveTF; }
            set { _beverageActiveTF = value; }
        }

        // Public Methods

        /* Second attempt to read file
        public void readFile()
        {
            int[] beverageID = new int[9999]; // Array to hold int beverageID
            string[] beverageName = new string[9999]; // Array to hold int beverageName
            string[] beveragePack = new string[9999]; // Array to hold int beveragePack
            decimal[] beveragePrice = new decimal[9999]; // Array to hold int beveragePrice
            string[] beverageActiveTF = new string[9999]; // Array to hold int beverageActiveTF

            int indexCounter = 0; // SETS INDEX COUNTER = 0

            try
            {
                StreamReader idNamePackPriceActiveTF = new StreamReader("beverage_list.csv");  // CREATES INSTANCE OF STREAM READER (OPENS FILE)


                while (idNamePackPriceActiveTF.Peek() != -1)
                {
                    string inputString = idNamePackPriceActiveTF.ReadLine(); // READ & PROCESS 1 RECORD AT A TIME
                    var fields = inputString.Split(',');    // READ RECORD USING FILE DELIMITER (,) ASSIGN TO ARRAY

                    beverageID[indexCounter] = Convert.ToInt32(fields[0]);
                    beverageName[indexCounter] = fields[1];
                    beveragePack[indexCounter] = fields[2];
                    beveragePrice[indexCounter] = Convert.ToDecimal(fields[3]);
                    beverageActiveTF[indexCounter] = fields[4];

                    indexCounter++; // ADD 1

                }

                idNamePackPriceActiveTF.Close(); // CLOSE

            }
            catch (Exception ex) // ERR MESSAGE
            {
                Console.WriteLine(ex.Message);
            }

            for (int i = 0; i < indexCounter; i++) // DISPLAYS ARRAYS
            {
                Console.Write( beverageID[i]);
                Console.Write( beverageName[i]);
                Console.Write( beveragePack[i]);
                Console.WriteLine();
            }
        }
        */

        /*
         * 1st attempt to read the file
        public static string[] readRecord(string searchTerm, string filepath, int positionOfSearchTerm)
        {
            positionOfSearchTerm--; // Allows method to be more user friendly (first field is 1 instead of 0)
            string[] recordNotFound = { "Record not found" };

            try
            {
                string[] lines = System.IO.File.ReadAllLines(@filepath); // Reads every line into a string array

                for (int i = 0; i < lines.Length; i++)
                {
                    string[] fields = lines[i].Split(',');
                    if (recordMatch(searchTerm, fields, positionOfSearchTerm))
                    {
                        Console.WriteLine("Beverage found");
                        return fields;
                    }
                }
                return recordNotFound;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error has occured");
                return recordNotFound; // Re-displays "record not found"
                throw new ApplicationException("Error has occured :", ex); // Prints error message in console
            }
        }

        public static bool recordMatch(string searchTerm, string[] record, int positionOfSearchTerm)
        {
            if (record[positionOfSearchTerm].Equals(searchTerm))
            {
                return true;
            }
            return false;
        }
        */

        public override string ToString()
        {
            return  _beverageID.ToString() + " " +
                   _beverageName + " " +
                   _beveragePack + " " +
                   _beveragePrice.ToString("c") + " " +
                   _beverageActiveTF;
        }


        // Constructors (always public)
        public CSVProcessor(int BeverageID, string BeverageName, string BeveragePack, decimal BeveragePrice, string BeverageActiveTF)
        {
            this._beverageID = BeverageID;
            this._beverageName = BeverageName;
            this._beveragePack = BeveragePack;
            this._beveragePrice = BeveragePrice;
            this._beverageActiveTF = BeverageActiveTF;
        }
    }
}
