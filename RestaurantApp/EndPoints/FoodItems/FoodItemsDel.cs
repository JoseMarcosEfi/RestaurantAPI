using Microsoft.AspNetCore.Mvc;

namespace RestaurantApp
{
    public class FoodItemsDel
    {
        public static string Template => "/foods/{id:guid}";
        public static string[] Methods => new string[] { HttpMethod.Delete.ToString(), };
        public static Delegate Handle => Action;

        public static IResult Action([FromRoute] Guid id, ApplicationDbContext context)
        {
            var food = context.FoodItems.Where(c => c.FoodId == id).FirstOrDefault();

            if (food != null)
            {
                context.FoodItems.Remove(food);
                context.SaveChanges();
            }

            return Results.Ok();
        }
    }
}
