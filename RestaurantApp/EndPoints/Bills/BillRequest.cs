namespace RestaurantApp
{
    public record BillRequest(List<FoodItems> ListOfItems, byte NumberOfPersons, List<Customer> Customers, double Amount);

}
