using System;

namespace LE03_02_Kropf
{
    internal class ChooseMenue
    {
        public static void ChooseDrink()
        {
            int userDecision;
            do 
            { 
                Console.WriteLine("\n\nWelcome to the Vending Machine!\n");
                Console.WriteLine("----------------------------------------\n" +
                                  "     1 = Coca Cola\n" +
                                  "     2 = (still) Mineral Water\n" +
                                  "     3 = (sparkling) Mineral Water\n" +
                                  "     4 = Ice Coffee\n" +
                                  "     5 = Red Bull\n" +
                                  "     0 = Exit\n" +
                                  "----------------------------------------\n" +
                                  "Choose what you want: \n");

                userDecision = InputCoverage.IntRequest();
                VendingMenue.Spreading(userDecision);

            } while (userDecision != 0);
        }
    }
}
