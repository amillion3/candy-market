using System;
using System.Collections.Generic;

namespace candy_market
{
    internal class CandyStorage
    {
        static List<Candy> _candies = new List<Candy>(); 

        internal IList<string> GetCandyTypes()
        {
            IList<string> CandyTypes = new List<string>()
            {
                "Hard Candy",
                "Taffy",
                "Jelly Bean",
                "Chocolate"
            };
            return CandyTypes;
        }

        internal IList<string> GetCandyNames()
        {
            IList<string> CandyNames = new List<string>()
            {
                "Sour/Sweet",
                "Caramel Flavored",
                "Saltwater",
                "Flavored",
                "Chocolate Bars",
                "Truffles"
            };
            return CandyNames;
        }

        internal IList<string> GetCandyManufacturers()
        {
            IList<string> CandyManufacturers = new List<string>()
            {
                "Jolly Ranchers",
                "Worther's",
                "Laffy Taffy",
                "Starburst",
                "Giradelli",
                "Lindt"
            };
            return CandyManufacturers;
        }

        internal IList<string> GetFlavorCategories()
        {
            IList<string> FlavorCategories = new List<string>()
            {
                "Sour",
                "Sweet",
                "Rich",
                "Nutty",
                "Fruity",
                "Hot"
            };
            return FlavorCategories;
        }

        internal void SaveNewCandy(ConsoleKey key)
        {
            throw new NotImplementedException();
            //_candies.Add(key);
        }

        internal void SaveCandyAcquisitionDate(string savedDate)
        {
            throw new NotImplementedException();
        }
    }
}