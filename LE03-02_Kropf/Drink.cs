using System;

namespace LE03_02_Kropf
{
    internal class Drink
    {
        public Drink(string name, string description, double price)
        {
            Name = name;
            Description = description;
            Price = price;
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; private set; }
        public static void UpdatePrice(Drink drink)
        {
            Console.WriteLine("Do you want \n0,5l = 1\n1l = 2");
            int chosenCapacity = InputCoverage.IntRequest();
            if (chosenCapacity == 2) { 
                drink.Price *= 2;
                Console.WriteLine("Price for 1l is: " + drink.Price + " EUR.");
            }
        }
    } // nachfragen: ToString, 1ne class weniger = worth?
}
