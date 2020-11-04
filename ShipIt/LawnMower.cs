using System;
using System.Collections.Generic;
using System.Text;

namespace ShipIt
{
    class LawnMower : IShippable
    {
        private string product = "Lawn mower";
        private decimal shipCost = 24.00M;
        public decimal ShipCost { get { return shipCost; } }
        public string Product { get { return product; } }
    }
}
