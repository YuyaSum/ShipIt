using System;
using System.Collections.Generic;
using System.Text;

namespace ShipIt
{
    class Bicycle : IShippable
    {
        private string product = "Bicycle";
        private decimal shipCost = 20.50M;

        public decimal ShipCost { get { return shipCost; } }
        public string Product { get { return product; } }

    }
}
