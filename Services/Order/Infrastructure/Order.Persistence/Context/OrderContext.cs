using Microsoft.EntityFrameworkCore;
using Order.Domain.Entities;
namespace Order.Persistence.Context
{
    public class OrderContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1440;initial Catalog=OrderDb;User=sa;Password=password2024;TrustServerCertificate=True");
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<OrderInfo> OrderInfos { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

    }
}
