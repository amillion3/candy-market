using System;
using System.Collections.Generic;

namespace candy_market
{
    internal class CandyStorage
    {
        static List<Candy> _candies = new List<Candy>();
        string tempCandyName = "";
        string tempCandyType = "";
        string tempManufacturer = "";
        string tempFlavorCategory = "";
        DateTime _tempDateReceived = new DateTime();

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

        internal void SetCandyType(string candyType)
        {
            //_candies.Add(new Candy() { CandyType = candyType });
            tempCandyType = candyType;
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

        internal void SetCandyNames(string candyName)
        {
            //_candies.Add(new Candy() { CandyType = candyType });
            tempCandyName = candyName;
        }

        internal IList<string> GetCandyManufacturers()
        {
            IList<string> CandyManufacturers = new List<string>()
            {
                "Jolly Ranchers",
                "Werther's",
                "Laffy Taffy",
                "Starburst",
                "Giradelli",
                "Lindt"
            };
            return CandyManufacturers;
        }

        internal void SetCandyManufacturer(string candyManuf)
        {
            //_candies.Add(new Candy() { CandyType = candyType });
            tempManufacturer = candyManuf;
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

        internal void SetCandyFlavorCategory(string candyFlavorCategory)
        {
            //_candies.Add(new Candy() { CandyType = candyType });
            tempFlavorCategory = candyFlavorCategory;
        }

        internal void SaveNewCandy(ConsoleKey key, string requestType)
        {
            int keyAsInt = (int)key;
            if (requestType == "CandyType")
            {
                switch (keyAsInt) 
                {
                    case 1:
                        SetCandyType("Hard Candy");
                        break;
                    case 2:
                        SetCandyType("Taffy");
                        break;
                    case 3:
                        SetCandyType("Jelly Bean");
                        break;
                    case 4:
                        SetCandyType("Chocolate");
                        break;
                }
            } else if (requestType == "CandyName")
            {
                switch (keyAsInt)
                {
                    case 1:
                        SetCandyNames("Sour/Sweet");
                        break;
                    case 2:
                        SetCandyNames("Caramel Flavored");
                        break;
                    case 3:
                        SetCandyNames("Saltwater");
                        break;
                    case 4:
                        SetCandyNames("Flavored");
                        break;
                    case 5:
                        SetCandyNames("Choclate Bars");
                        break;
                    case 6:
                        SetCandyNames("Truffles");
                        break;
                }
            } else if (requestType == "CandyManuf")
            {
                switch (keyAsInt)
                {
                    case 1:
                        SetCandyManufacturer("Jolly Ranchers");
                        break;
                    case 2:
                        SetCandyManufacturer("Werther's");
                        break;
                    case 3:
                        SetCandyManufacturer("Laffy Taffy");
                        break;
                    case 4:
                        SetCandyManufacturer("Starburst");
                        break;
                    case 5:
                        SetCandyManufacturer("Giradelli");
                        break;
                    case 6:
                        SetCandyManufacturer("Lindt");
                        break;
                }
            } else if (requestType == "CandyFlavor")
            {
                switch (keyAsInt)
                {
                    case 1:
                        SetCandyFlavorCategory("Sour");
                        break;
                    case 2:
                        SetCandyFlavorCategory("Sweet");
                        break;
                    case 3:
                        SetCandyFlavorCategory("Rich");
                        break;
                    case 4:
                        SetCandyFlavorCategory("Nutty");
                        break;
                    case 5:
                        SetCandyFlavorCategory("Fruity");
                        break;
                    case 6:
                        SetCandyFlavorCategory("Hot");
                        break;
                }
            };
        }

        internal void SaveCandyAcquisitionDate(string savedDate)
        {
            throw new NotImplementedException();
        }
    }
}