using System;

namespace LE03_02_Kropf
{
    internal class DisplayDrink
    {
        public static void Display(Drink chosenDrink, int productNumber)
        {
            Console.WriteLine("\nYou chose Nr. " + productNumber +
                              "\nName: " + chosenDrink.Name +
                              "\nDescription: " + chosenDrink.Description +
                              "\nPrice: " + chosenDrink.Price + " EUR.\n");
        }
    }
}
