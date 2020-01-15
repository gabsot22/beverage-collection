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

        public decimal BeveragePrice
        {
            get { return _beveragePrice; }
            set { _beveragePrice = value; }
        }

        public string BeveragePack
        {
            get { return _beveragePack; }
            set { _beveragePack = value; }
        }

        public string BeverageActiveTF
        {
            get { return _beverageActiveTF; }
            set { _beverageActiveTF = value; }
        }

        // Public Methods


        
        public override string ToString()
        {
            return _beverageID.ToString() + " " +
                   _beverageName + " " +
                   _beveragePack + " " +
                   _beveragePrice.ToString("c") + " " +
                   _beverageActiveTF;
        }
        

        // Constructors (always public)
        public Beverage(int BeverageID, string BeverageName, string BeveragePack, decimal BeveragePrice, string BeverageActiveTF)
        {
            this._beverageID = BeverageID;
            this._beverageName = BeverageName;
            this._beveragePack = BeveragePack;
            this._beveragePrice = BeveragePrice;
            this._beverageActiveTF = BeverageActiveTF;
        }
    }
}
