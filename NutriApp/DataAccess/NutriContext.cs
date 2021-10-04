using Microsoft.EntityFrameworkCore;

namespace NutriApp.Models
{
    public class NutriContext : DbContext
    {
        public NutriContext() : base()
        {
        }
        public DbSet<Item> Items { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Meal> Meals { get; set; }
    }
}
