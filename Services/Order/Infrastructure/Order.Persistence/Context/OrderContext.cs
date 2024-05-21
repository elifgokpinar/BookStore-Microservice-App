using Microsoft.EntityFrameworkCore;
using Order.Domain.Entities;
namespace Order.Persistence.Context
{
    public class OrderContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=...;initial Catalog=OrderDb;integrated Security=true;");
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<OrderInfo> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

    }
}
