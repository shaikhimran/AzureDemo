using Microsoft.EntityFrameworkCore;

namespace LinkedInDemo.api.Orders.Db
{
    public class OrderDbContext:DbContext
    {
        public DbSet<Order> Orders { get; set; }

        public OrderDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
