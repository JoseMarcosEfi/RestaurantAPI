using RestaurantApp.Domain.Items;
using RestaurantApp.Domain.Persons;

namespace RestaurantApp.Domain
{
    public class Bill
    {
        public int Id { get; set; }
        public Customer Custom { get; set; }
        public List<FoodItems> Items { get; set; }
    }
}
