using System;

namespace LE03_02_Kropf
{
    internal class MoneyExpenditure
    {
        public static void Expense(Drink drink)
        {
            Console.WriteLine("For now, you can only pay with 5/10 EUR note.\nHow much do you insert?");
            int payment = InputCoverage.IntRequest();
            if(payment != 5 && payment != 10 ) 
            {
                Console.WriteLine("\nAs said before, this vending machine ONLY accepts 5/10 EUR notes!\nPayment failed..");
            }
            else
            {
                Console.WriteLine("You payed with a " + payment + " EUR note.\nYou get " + (payment - drink.Price) + " EUR back.\n");
            }
        }
    }
}
