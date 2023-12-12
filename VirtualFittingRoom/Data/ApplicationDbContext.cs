using Microsoft.EntityFrameworkCore;
using VirtualFittingRoom.Models;
namespace VirtualFittingRoom.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserProduct>().HasKey(table => new
            {
                table.IDUser,
                table.IDProduct,
                table.CreateAt
            });
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<UserProduct> UserProducts { get; set; }
    }

}
