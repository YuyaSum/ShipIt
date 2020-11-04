using System;
using System.Collections.Generic;
using System.Text;

namespace ShipIt
{
    class BaseBallGlove : IShippable
    {
        private string product = "Baseball Glove";
        private decimal shipCost = 3.23M;
        public decimal ShipCost { get { return shipCost; } }
        public string Product { get { return product; } }
    }
}
