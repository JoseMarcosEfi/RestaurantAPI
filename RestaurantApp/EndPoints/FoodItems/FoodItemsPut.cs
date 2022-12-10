using Microsoft.AspNetCore.Mvc;

namespace RestaurantApp
{
    public class FoodItemsPut
    {
        public static string Template => "/foods/{id:guid}";
        public static string[] Methods => new string[] { HttpMethod.Put.ToString(), };
        public static Delegate Handle => Action;

        public static IResult Action([FromRoute] Guid id, FoodItemsRequest foodItemsRequest, ApplicationDbContext context)
        {
            var food = context.FoodItems.Where(c => c.FoodId == id).FirstOrDefault();

            if (food == null)
                return Results.NotFound();


            food.EditeInfo(foodItemsRequest.Name, foodItemsRequest.Price, foodItemsRequest.Description);

            if (!food.IsValid)
                return Results.ValidationProblem(food.Notifications.ConvertToProblemDetails());


            context.SaveChanges();

            return Results.Ok();
        }
    }
}
