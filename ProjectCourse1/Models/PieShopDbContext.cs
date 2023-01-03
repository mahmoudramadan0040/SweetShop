using Microsoft.EntityFrameworkCore;

namespace ProjectCourse1.Models
{
    public class PieShopDbContext:DbContext
    {
        public PieShopDbContext(DbContextOptions<PieShopDbContext> options):base (options) { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Pie> Pies { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }

    }
}
