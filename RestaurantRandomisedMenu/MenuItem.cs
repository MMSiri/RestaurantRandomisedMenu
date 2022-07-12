using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantRandomisedMenu
{
    class MenuItem
    {
        public static Random Randomiser = new Random();

        public string[] Proteins = { "Roast Beef", "Salami", "Turkey", "Ham", "Pastrami", "Tofu" };
        public string[] Condiments = { "Yellow Mustard", "Brown Mustard", "Honey Mustard", "Mayo", "Relish", "French Dressing" };
        public string[] Breads = { "Rye", "White", "Wheat", "Pumpernickel", "a Roll" };

        public string Description = "";
        public string Price; 

        public void Generate()
        {
            string randomProtein = Proteins[Randomiser.Next(Proteins.Length)];
            string randomCondiment = Condiments[Randomiser.Next(Condiments.Length)];
            string randomBread = Breads[Randomiser.Next(Breads.Length)];

            Description = randomProtein + " with " + randomCondiment + " on "+ randomBread;
            decimal bucks = Randomiser.Next(2, 5);
            decimal cents = Randomiser.Next(1, 100);
            decimal price = bucks + (cents * .01M);
            Price = price.ToString("c");
        }

    }
}
