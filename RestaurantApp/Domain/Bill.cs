
namespace RestaurantApp
{ 
    public class Bill
    {
        public Guid Id { get; private set; }
        public List<Customer> Custom { get; private set; }
        public List<FoodItems> Items { get; private set; }
        public double Ammount { get; set; }

        public Bill() { }

        public Bill(int id, double ammount)
        {
            Id = Guid.NewGuid();
            Custom = new List<Customer>();
            Items = new List<FoodItems>();
            Ammount = ammount;
        }



    }
}
