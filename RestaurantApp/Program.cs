

using Microsoft.AspNetCore.Builder;
using RestaurantApp;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSqlServer<ApplicationDbContext>(builder.Configuration["Database:RestaurantApp"]);


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapMethods(BillPost.Template, BillPost.Methods, BillPost.Handle);
app.MapMethods(BillGetAll.Template, BillGetAll.Methods, BillGetAll.Handle);
app.MapMethods(BillPut.Template, BillPut.Methods, BillPut.Handle);
app.MapMethods(FoodItemsGetAll.Template, FoodItemsGetAll.Methods, FoodItemsGetAll.Handle);
app.MapMethods(FoodItemsPost.Template, FoodItemsPost.Methods, FoodItemsPost.Handle);
app.MapMethods(FoodItemsPut.Template, FoodItemsPut.Methods, FoodItemsPut.Handle);
app.MapDelete(FoodItemsDel.Template, FoodItemsDel.Handle);

app.Run();
