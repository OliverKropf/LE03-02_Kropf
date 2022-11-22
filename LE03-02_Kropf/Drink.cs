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
    } // nachfragen: ToString, 1ne class weniger = worth?
}
