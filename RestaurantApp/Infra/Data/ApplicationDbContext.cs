using Microsoft.EntityFrameworkCore;

namespace RestaurantApp
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<FoodItems> FoodItems { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Bill> Bills { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
           
        }
    }
}
