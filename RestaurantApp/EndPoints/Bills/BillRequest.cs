namespace RestaurantApp.EndPoints.Bills
{
    public class BillRequest
    {
        public List<FoodItems> ListOfItems { get; set; }
        public byte NumberOfPersons { get; set; }
        public List<Customer> Customers { get; set; }
        public double Ammount { get; set; }
    }
}
