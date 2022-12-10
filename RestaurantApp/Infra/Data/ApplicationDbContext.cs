using Flunt.Notifications;
using Microsoft.EntityFrameworkCore;

namespace RestaurantApp
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<FoodItems> FoodItems { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Bill> Bills { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Ignore<Notification>();

            builder.Ignore<Customer>();

            builder.Entity<FoodItems>()
                .Property(p => p.Name).IsRequired()
                .HasMaxLength(20);
            builder.Entity<FoodItems>()
                .Property(p => p.Description).IsRequired()
                .HasMaxLength(50);
            builder.Entity<FoodItems>()
                .Property(p => p.Price).IsRequired();

        }
        protected override void ConfigureConventions(ModelConfigurationBuilder configuration)
        {
            configuration.Properties<string>()
                .HaveMaxLength(100);
        }
    }
}
