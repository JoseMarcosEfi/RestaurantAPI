using Flunt.Notifications;
using Flunt.Validations;
using System.ComponentModel.DataAnnotations;

namespace RestaurantApp
{
    public class Bill : Notifiable<Notification>
    {
        [Key]
        public Guid BillId { get; set; }
        public List<Customer> Custom { get; private set; } = new List<Customer>();
        public List<FoodItems> Items { get; private set; } = new List<FoodItems>();
        public double Amount { get; set; }

        public Bill() { }

        public Bill(int id, double amount, List<Customer> customers, List<FoodItems> foodItems)
        {
            BillId = Guid.NewGuid();
            Custom = customers;
            Items = foodItems;
            Amount = amount;
            Validate();
        }

        private void Validate()
        {
            var contract = new Contract<Bill>()
                .IsNotNull(Amount, "Amount");
            AddNotifications(contract);

        }

        public void EditeInfo(double amount, byte numberOfPerson)
        {
            Amount = amount;


            Validate();

        }

    }
}
