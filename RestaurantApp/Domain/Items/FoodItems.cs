using Flunt.Notifications;
using Flunt.Validations;
using System.ComponentModel.DataAnnotations;

namespace RestaurantApp
{
    public class FoodItems : Notifiable<Notification>
    {
        [Key]
        public Guid FoodId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }

        public FoodItems()
        {
        }

        public FoodItems(string name, double price, string description)
        {
            FoodId = Guid.NewGuid();
            Name = name;
            Price = price;
            Description = description;
            Validate();
        }

        private void Validate()
        {
            var contract = new Contract<FoodItems>()
                .IsNotNullOrEmpty(Name, "Name")
                .IsGreaterOrEqualsThan(Name, 3, "Name")
                .IsNotNullOrEmpty(Description, "Description")
                .IsGreaterOrEqualsThan(Description, 5, "Description");
            AddNotifications(contract);
        }
        public void EditeInfo(string name, double price, string description)
        {
            Name = name;
            Price = price;
            Description = description;
            Validate();
        }
    }
}
