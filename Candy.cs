using System;

namespace candy_market
{
    internal class Candy
    {
        public string Name { get; set; }
        public string CandyType { get; set; }
        public string Manufacturer { get; set; }
        public string FlavorCategory { get; set; }
        public DateTime DateReceived { get; set; }
    }

    // Need an I/List candy enum ...?
}