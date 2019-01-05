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
        DateTime tempDateReceived = new DateTime();

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
            tempFlavorCategory = candyFlavorCategory;
        }

        internal void SetCandyAcquisitionDate(string savedDate)
        {
            tempDateReceived = DateTime.Parse(savedDate);
        }

        internal void SaveNewCandy(ConsoleKey key, string requestType)
        {
            var keyValue = key.ToString();
            Console.WriteLine(key.ToString());
            if (requestType == "CandyType")
            {
                switch (keyValue) 
                {
                    case "D1":
                        SetCandyType("Hard Candy");
                        break;
                    case "D2":
                        SetCandyType("Taffy");
                        break;
                    case "D3":
                        SetCandyType("Jelly Bean");
                        break;
                    case "D4":
                        SetCandyType("Chocolate");
                        break;
                    default:
                        SetCandyNames("ERROR");
                        break;
                }
            } else if (requestType == "CandyName")
            {
                switch (keyValue)
                {
                    case "D1":
                        SetCandyNames("Sour/Sweet");
                        break;
                    case "D2":
                        SetCandyNames("Caramel Flavored");
                        break;
                    case "D3":
                        SetCandyNames("Saltwater");
                        break;
                    case "D4":
                        SetCandyNames("Flavored");
                        break;
                    case "D5":
                        SetCandyNames("Choclate Bars");
                        break;
                    case "D6":
                        SetCandyNames("Truffles");
                        break;
                    default:
                        SetCandyNames("ERROR");
                        break;
                }
            } else if (requestType == "CandyManuf")
            {
                switch (keyValue)
                {
                    case "D1":
                        SetCandyManufacturer("Jolly Ranchers");
                        break;
                    case "D2":
                        SetCandyManufacturer("Werther's");
                        break;
                    case "D3":
                        SetCandyManufacturer("Laffy Taffy");
                        break;
                    case "D4":
                        SetCandyManufacturer("Starburst");
                        break;
                    case "D5":
                        SetCandyManufacturer("Giradelli");
                        break;
                    case "D6":
                        SetCandyManufacturer("Lindt");
                        break;
                    default:
                        SetCandyNames("ERROR");
                        break;
                }
            } else if (requestType == "CandyFlavor")
            {
                switch (keyValue)
                {
                    case "D1":
                        SetCandyFlavorCategory("Sour");
                        break;
                    case "D2":
                        SetCandyFlavorCategory("Sweet");
                        break;
                    case "D3":
                        SetCandyFlavorCategory("Rich");
                        break;
                    case "D4":
                        SetCandyFlavorCategory("Nutty");
                        break;
                    case "D5":
                        SetCandyFlavorCategory("Fruity");
                        break;
                    case "D6":
                        SetCandyFlavorCategory("Hot");
                        break;
                    default:
                        SetCandyNames("ERROR");
                        break;
                }
            };
        }
        
        internal void PersistNewCandyObject()
        {
            _candies.Add(new Candy() {
                Name = tempCandyName,
                CandyType = tempCandyType,
                Manufacturer = tempManufacturer,
                FlavorCategory = tempFlavorCategory,
                DateReceived = tempDateReceived,
            });
        }

        public List<Candy> ReturnCandyInventory()
        {
            return _candies;
        }
    }
}