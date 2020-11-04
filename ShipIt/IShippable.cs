using System;
using System.Collections.Generic;
using System.Text;

namespace ShipIt
{
    interface IShippable
    {
        decimal ShipCost { get; }
        string Product { get; }
    }
}
