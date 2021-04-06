using Microsoft.EntityFrameworkCore;
namespace ECommerce.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions option) : base (option) {}

        public DbSet<Customer> customers {get; set;}
        public DbSet<Order> orders {get; set;}
        public DbSet<Product> products {get; set;}
    }
}