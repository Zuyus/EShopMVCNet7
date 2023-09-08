using Microsoft.EntityFrameworkCore;
using EShopMVCNet7.Models;

namespace EShopMVCNet7.Models
{
    public class EShopDbContext : DbContext
    {
        public DbSet<AppCategory> AppCategories { get; set; }
        public DbSet<AppOrder> AppOrders { get; set; }
        public DbSet<AppOrderDetail> AppOrderDetails { get; set; }
        public DbSet<AppProduct> AppProducts { get; set; }
        public DbSet<AppProductImage> AppProductImages { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }

        public EShopDbContext(DbContextOptions options) : base(options)
          {

          }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    var connection = "Server=DESKTOP-VLRDD54\\MSSQLSERVER01;Database=RazorPage;Trusted_Connection=True;Encrypt=False";
        //    optionsBuilder.UseSqlServer(connection);
        //}
    }
}