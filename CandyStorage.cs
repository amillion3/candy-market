using System;
using System.Collections.Generic;

namespace candy_market
{
    internal class CandyStorage
    {
        static List<Candy> _candies = new List<Candy>(); 

        // name
        // manuf
        // flavor
        // date
        // type

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

        internal void SaveNewCandy(ConsoleKey key)
        {
            throw new NotImplementedException();
        }
    }
}