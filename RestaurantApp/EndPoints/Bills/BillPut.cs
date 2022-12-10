using Microsoft.AspNetCore.Mvc;


namespace RestaurantApp
{
    public class BillPut
    {
        public static string Template => "/bill/{id:guid}";
        public static string[] Methods => new string[] { HttpMethod.Put.ToString() };
        public static Delegate Handle => Action;
        public static IResult Action([FromRoute] Guid id, BillRequest billRequest, ApplicationDbContext context)
        {
            var bill = context.Bills.Where(b => b.BillId == id).FirstOrDefault();
            if (bill == null) return Results.NotFound();

            bill.EditeInfo(billRequest.Amount, billRequest.NumberOfPersons);


            return Results.NotFound();
        }
    }
}
