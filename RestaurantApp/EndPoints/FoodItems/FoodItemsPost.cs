namespace RestaurantApp
{
    public class FoodItemsPost
    {
        public static string Template => "/food";
        public static string[] Methods => new string[] { HttpMethod.Post.ToString(), };
        public static Delegate Handle => Action;

        public static IResult Action(FoodItemsRequest foodItemsRequest, ApplicationDbContext context)
        {
            var food = new FoodItems(foodItemsRequest.Name, foodItemsRequest.Price, foodItemsRequest.Description);

            if (!food.IsValid)
            {
                return Results.ValidationProblem(food.Notifications.ConvertToProblemDetails());
            }
            context.FoodItems.Add(food);
            context.SaveChanges();

            return Results.Created($"/food/{food.FoodId}", food.FoodId);
        }
    }
}
