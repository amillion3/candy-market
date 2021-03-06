﻿using System;

namespace candy_market
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = SetupNewApp();
            // this do/while loop keeps the program running until the user enters
            //    '0' at the Main Menu screen (to exit the console app)
            do {
                var userInput = MainMenu(db);
                HandleInput(userInput);
            }
            while (1 == 1);
        }

        internal static void HandleInput(char userInputABC)
        {
            var inputNumber = userInputABC;
            CandyStorage emptyCandyStorage = new CandyStorage();

            if (inputNumber == 49)
            {
                AddNewCandy(emptyCandyStorage);
            }
            else if (inputNumber == 50)
            {
                EatSomeCandy();
            } else
            {
                Environment.Exit(0);
            }
        }

        internal static CandyStorage SetupNewApp()
        {
            Console.Title = "Cross Confectioneries Incorporated";

            var db = new CandyStorage();

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            return db;
        }

        internal static char MainMenu(CandyStorage db)
        {
            View mainMenu = new View()
                .AddMenuOption("Did you just get some new candy? Add it here.")
                .AddMenuOption("Do you want to eat some candy? Take it here.")
                .AddMenuText("Press 0 to exit.");
            Console.Write(mainMenu.GetFullMenu());
            var userOption = Console.ReadKey().KeyChar;
            return userOption;
        }

        internal static void AddNewCandy(CandyStorage db)
        {
            //  Candy Types  //
            var candyTypes = db.GetCandyTypes();
            var newCandyMenuTypes = new View()
                .AddMenuText("What type of candy did you get?")
                .AddMenuOptions(candyTypes);
            Console.Write(newCandyMenuTypes.GetFullMenu());

            var selectedCandyType = Console.ReadKey();
            db.SaveNewCandy(selectedCandyType.Key, "CandyType");

            //  Candy Names //
            var candyNames = db.GetCandyNames();
            var newCandyMenuNames = new View()
                .AddMenuText("What is the name of the candy?")
                .AddMenuOptions(candyNames);
            Console.Write(newCandyMenuNames.GetFullMenu());

            var selectedCandyName = Console.ReadKey();
            db.SaveNewCandy(selectedCandyName.Key, "CandyName");

            //  Candy Manufacturers  //
            var candyManufacturers = db.GetCandyManufacturers();
            var newCandyMenuManufacturers = new View()
                .AddMenuText("Who made the candy?")
                .AddMenuOptions(candyManufacturers);
            Console.Write(newCandyMenuManufacturers.GetFullMenu());

            var selectedCandyManufacturer = Console.ReadKey();
            db.SaveNewCandy(selectedCandyManufacturer.Key, "CandyManuf");

            //  Candy Flavors  //
            var candyFlavors = db.GetFlavorCategories();
            var newCandyMenuFlavor = new View()
                .AddMenuText("What flavor is the candy?")
                .AddMenuOptions(candyFlavors);
            Console.Write(newCandyMenuFlavor.GetFullMenu());

            var selectedCandyFlavor = Console.ReadKey();
            db.SaveNewCandy(selectedCandyFlavor.Key, "CandyFlavor");

            //  Candy Acquired Date  //
            var newCandyMenuDateAcquired = new View()
                .AddMenuText("When did you acquire the candy? MM/DD/YYYY");
            Console.Write(newCandyMenuDateAcquired.GetFullMenu());
            var dateOfAcquisition = Console.ReadLine();
            db.SetCandyAcquisitionDate(dateOfAcquisition);
            db.PersistNewCandyObject();
        }

        internal static void EatSomeCandy()
        {
            var db = new CandyStorage();
            var currentCandyInventory = db.ReturnCandyInventory();
            if (currentCandyInventory.Count < 1)
            {
                var eatCandy = new View()
                    .AddMenuText("You have no candy");
                Console.Write(eatCandy.GetFullMenu());
                Console.ReadKey();
            } else
            {
                var viewCandy = new View()
                    .AddMenuText("Here is your candy inventory:");
                Console.Write(viewCandy.GetFullMenu());
                for (int i = 0; i < currentCandyInventory.Count; i++)
                {
                    Console.WriteLine("");
                    Console.WriteLine("         Candy Name: " + currentCandyInventory[i].Name);
                    Console.WriteLine("         Candy Type: " + currentCandyInventory[i].CandyType);
                    Console.WriteLine(" Candy Manufacturer: " + currentCandyInventory[i].Manufacturer);
                    Console.WriteLine("       Candy Flavor: " + currentCandyInventory[i].FlavorCategory);
                    Console.WriteLine("Candy Date Received: " + currentCandyInventory[i].DateReceived);
                }
                Console.WriteLine("");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
            }
        }
    }
}
