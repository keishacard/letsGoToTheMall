using System;

namespace the_mall
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            DollarStore Dollarama = new DollarStore();

            DollarItem MultiColorPen = new DollarItem()
            {
                Name = "Multicolored pen with 12 colors"
            };

            Dollarama.AddToInventory("mcp", MultiColorPen);

            FoodStore Cinnabon = new FoodStore();

            FoodItem ClassicRoll = new FoodItem()
            {
                Name = "The classic roll",
                Price = 3.50,
                Calories = 880
            };

            FoodItem CaramelPecanbon = new FoodItem()
            {
                Name = "everyone fights over it",
                Price = 6,
                Calories = 1080
            };

            Cinnabon.AddToInventory("tcr", ClassicRoll);
            Cinnabon.AddToInventory("cpb", CaramelPecanbon);

            Console.WriteLine(Dollarama.GetFromInventory("mcp"));
            Console.WriteLine(Cinnabon.GetFromInventory("cpb"));
            // above just returns the-mall.DollarItem

            Console.WriteLine(Dollarama.GetFromInventory("mcp").Name);
            // above returns "muliticolored pen with 12 colors"
        }
    }
}
