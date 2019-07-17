using System.Collections.Generic;

namespace the_mall
{

    public class DollarStore : IStore<DollarItem>
    {
        // can use a list, but dictionary is what Jisie chose for [] use
        private Dictionary<string, DollarItem> _inventory = new Dictionary<string, DollarItem>();

        private double _price = 1.00;

        public void AddToInventory(string dollarName, DollarItem dollarItem)
        {
            _inventory.Add(dollarName, dollarItem);
        }

        public DollarItem GetFromInventory(string name)
        {
            return _inventory[name];
        }
    }
}