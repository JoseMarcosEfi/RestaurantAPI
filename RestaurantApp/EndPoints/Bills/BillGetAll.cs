namespace RestaurantApp
{
    public class BillGetAll
    {
        public static string Template => "/bills";
        public static string[] Methods => new string[] { HttpMethod.Get.ToString() };
        public static Delegate Handle => Action;

        public static IResult Action(int? page, int? rows, ApplicationDbContext context)
        {
            var bills = context.Bills.ToList();
            var response = bills.Select(b => new BillResponse { ResponseId = b.BillId, Amount = b.Amount });

            return Results.Ok(response);
        }
    }
}
