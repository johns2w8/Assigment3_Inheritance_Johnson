using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMaintenance
{
    // Wes Johnson

    //Plant represents inheritance well by being a sub class of InvItem being essentially a new version of the class with something to 
    //differentiate them
    public class Plant : InvItem
    {
        public string Size { get; set; }
        public Plant() { }
        public Plant(int itemNo, string description, decimal price, string size) : base(itemNo, description, price)
        {
            Size = size;
        }

        public override string GetDisplayText(string sep)
        {
            return Size + sep + base.GetDisplayText(sep);
        }
    }
}
