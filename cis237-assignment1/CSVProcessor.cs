﻿/* Gabriel Soto
 * CIS 237 MW 6:00-8:15pm
 * 1/22/20
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // Use for streamreader

namespace cis237_assignment1
{
    class CSVProcessor
    {
        // Class for reading CSV file

        // No variables
        // No Properties
        // No Constructor

        // Methods
        public bool ImportCsv(string pathToCSVFile, Beverage[] beverages)
        {
            // Declare the streamReader
            StreamReader streamReader = null;
          
            try
            {
                // Declare a string for the line
                string line;

                // Make instance of the stream reader
                streamReader = new StreamReader(pathToCSVFile);

                // Setup a counter to use as an index for the array
                int counter = 0;

                // While we are still reading a line from the file
                while((line = streamReader.ReadLine()) != null)
                {
                    // Process the line
                    processLine(line, beverages, counter++);
                }

                
                // Read through the whole file, so we can return true
                return true;
            }
            catch (FileNotFoundException ex)
            {
                // Output the exception and the stacktrace for the exception
                Console.WriteLine(ex.ToString());
                Console.WriteLine();
                Console.WriteLine(ex.StackTrace);

                return false;
            }
            catch (Exception ex)
            {
                // Output the exception and the stacktrace for the exception
                Console.WriteLine(ex.ToString());
                Console.WriteLine();
                Console.WriteLine(ex.StackTrace);

                return false;
            }
            finally
            {
                // Stuff that will run regardless of whether try succeeds or catch gets called.

                // If the stream reader was instantciated, make sure it is closed before exiting the reader
                if (streamReader != null)
                {
                    streamReader.Close();
                }
            }
        }

        public void processLine(string line, Beverage[] beverages, int index)
        {
            // Declare array of parts that will contain the results of splitting the read in string
            string[] parts = line.Split(',');

            // Assign each part to a variable
            string bevID = parts[0];
            string bevName = parts[1];
            string bevPack = parts[2];
            decimal bevPrice = decimal.Parse(parts[3]);
            string bevActiveTF = parts[4];

            // Add a new beverage into the array that was passed in
            beverages[index] = new Beverage(bevID, bevName, bevPack, bevPrice, bevActiveTF);
           
        }

        // Method to search for inputed beverage in the array
        public void Search(Beverage[] beverages)
        {
            // Reads input line from user
            string beverageName = Console.ReadLine();
            bool match = false;

            // Loop to search every line in the array
            for (int i = 0; i < beverages.Length; i++)
            {
                // If the input matches the beverage... math is found
                if (beverageName == beverages[i].ToString())
                {
                    match = true;
                }
                
            }
            if (match == true)
            {
                Console.WriteLine(); 
                Console.WriteLine("Match has been found");
            }
            if (match == false)
            {
                Console.WriteLine("Match not found");
            }
        }

        //public void Add(Beverage[] beverages)
        //{
        //    for (int i = 0; i < beverages.Length; i++)
        //    {
        //        Console.ReadLine() = beverages[i].ToString();
        //    }
        //}
    }
}
