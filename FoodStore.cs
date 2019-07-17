using System.Collections.Generic;

namespace the_mall
{
    public class FoodStore : IStore<FoodItem>
    {
        private Dictionary<string, FoodItem> _inventory = new Dictionary<string, FoodItem>();

        public void AddToInventory(string foodName, FoodItem food)
        {
            _inventory.Add(foodName, food);
        }

        public FoodItem GetFromInventory(string name)
        {
            return _inventory[name];
        }
    }
}