namespace RestaurantApp
{
    public class FoodItemsGetAll
    {
        public static string Template => "/foods";
        public static string[] Methods => new string[] { HttpMethod.Get.ToString(), };
        public static Delegate Handle => Action;

        public static IResult Action(ApplicationDbContext context)
        {
            var foods = context.FoodItems.ToList();
            var response = foods.Select(f => new FoodItemsReponse { ResponseId = f.FoodId, Name = f.Name, Price = f.Price, Description = f.Description });

            return Results.Ok(response);
        }
    }
}
