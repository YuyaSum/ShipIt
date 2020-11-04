using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Text;

namespace ShipIt
{
    class Shipper
    {
        private List<IShippable> shippingList = new List<IShippable>();
        public void Add(IShippable item)
        {
            if (item is Bicycle)
            {
                shippingList.Add(item);
            }
            else if (item is LawnMower)
            {
                shippingList.Add(item);
            }
            else if (item is BaseBallGlove) {
                shippingList.Add(item);
            } else {
                shippingList.Add(item);
            }
        }

        public List<IShippable> getList() {
            return shippingList;
        }

        //Will be in charge of calculating and outputing the total shipping from each product's shipping cost.
        public decimal calcShipping() {
            decimal total = 0m;

            foreach (IShippable item in shippingList) {
                if (item is Bicycle)
                {
                    total += ((Bicycle)item).ShipCost;
                }
                else if (item is LawnMower)
                {
                    total += ((LawnMower)item).ShipCost;
                }
                else if (item is BaseBallGlove)
                {
                    total += ((BaseBallGlove)item).ShipCost;
                }
                else
                {
                    total += ((Crackers)item).ShipCost;
                }
            }
            return total;
        }
    }
}
