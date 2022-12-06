
namespace RestaurantApp
{ 
    public class Bill
    {
        public Guid Id { get; set; }
        public Customer Custom { get; set; }
        public List<FoodItems> Items { get; set; }

        public Bill() { }

        public Bill(int id)
        {
            Id = Guid.NewGuid();
            
        }



    }
}
