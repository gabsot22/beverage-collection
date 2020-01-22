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
    class Beverage
    {
        // Variables / Backing fields
        private string _beverageID;
        private string _beverageName;
        private decimal _beveragePrice;
        private string _beveragePack;
        private string _beverageActiveTF;

        // Properties (to use in Program.cs)
        public string BeverageID
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

        // Method to put ID, Name, Pack, Price, and ActiveTF into a single string
        public override string ToString()
        {
            return _beverageID + " " +
                   _beverageName + " " +
                   _beveragePack + " " +
                   _beveragePrice.ToString("c") + " " +
                   _beverageActiveTF;
        }
        

        // Constructors (always public)
        public Beverage(string BeverageID, string BeverageName, string BeveragePack, decimal BeveragePrice, string BeverageActiveTF)
        {
            this._beverageID = BeverageID;
            this._beverageName = BeverageName;
            this._beveragePack = BeveragePack;
            this._beveragePrice = BeveragePrice;
            this._beverageActiveTF = BeverageActiveTF;
        }
    }
}
