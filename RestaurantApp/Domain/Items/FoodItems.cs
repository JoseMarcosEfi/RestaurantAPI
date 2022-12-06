namespace RestaurantApp
{
    public class FoodItems
    {
        public Guid Id { get; private set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }

        public FoodItems()
        {
        }

        public FoodItems(Guid id, string name, double price, string description)
        {
            Id = Guid.NewGuid();
            Name = name;
            Price = price;
            Description = description;
        }
    }
}
