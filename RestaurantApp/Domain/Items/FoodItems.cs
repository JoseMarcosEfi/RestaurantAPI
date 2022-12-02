namespace RestaurantApp.Domain.Items
{
    public class FoodItems
    {
        public Guid Id { get; private set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
    }
}
