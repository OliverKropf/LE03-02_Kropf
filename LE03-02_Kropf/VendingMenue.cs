namespace LE03_02_Kropf
{
    internal class VendingMenue
    {
        public static void Spreading(int decision) 
        {
            switch(decision)
            {
                case 1: //cola
                    Drink Cola = new Drink("Coca Cola", "53g sugar per 0,5l/Coloring E 150d", 1.50);
                    DisplayDrink.Display(Cola, decision);
                    Drink.UpdatePrice(Cola);
                    MoneyExpenditure.Expense(Cola);
                    break;
                case 2: // mineral still
                    Drink Mineral = new Drink("Mineral Water (still)", "Sulfate/Magnesium", 0.80);
                    DisplayDrink.Display(Mineral, decision);
                    Drink.UpdatePrice(Mineral);
                    MoneyExpenditure.Expense(Mineral);
                    break;
                case 3: // mineral sparkling
                    Drink SparklingWater = new Drink("Mineral Water (sparkling)", "Sulfate/Magnesium", 0.80);
                    DisplayDrink.Display(SparklingWater, decision);
                    Drink.UpdatePrice(SparklingWater);
                    MoneyExpenditure.Expense(SparklingWater);
                    break;
                case 4: //ice coffee
                    Drink IceCoffee = new Drink("Ice Coffee", "Glucose syrup/Coloring(Carotine)", 1.20);
                    DisplayDrink.Display(IceCoffee, decision);
                    Drink.UpdatePrice(IceCoffee);
                    MoneyExpenditure.Expense(IceCoffee);
                    break;
                case 5: // red bull
                    Drink RedBull = new Drink("Red Bull", "Glucose/Taurine/Caffeine", 2.40);
                    DisplayDrink.Display(RedBull, decision);
                    Drink.UpdatePrice(RedBull); 
                    MoneyExpenditure.Expense(RedBull);
                    break;
            }
        }
    }
}
