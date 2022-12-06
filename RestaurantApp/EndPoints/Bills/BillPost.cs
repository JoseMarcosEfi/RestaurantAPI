using RestaurantApp.EndPoints.Bills;

namespace RestaurantApp
{
    public class BillPost
    {
        public static string Template => "/bill";
        public static string[] Methods => new string[] { HttpMethod.Post.ToString() };
        public static Delegate Handle => Action;
        public static IResult Action(BillRequest billRequest, ApplicationDbContext context)
        {
            var Bill = new Bill()
            {
                Ammount = billRequest.Ammount,
                
            };
            context.Bills.Add(Bill);
            context.SaveChanges();

            return Results.Created($"/Bills/{Bill.Id}", Bill.Id);
        }
    }
}
