using Microsoft.EntityFrameworkCore;
using HTTProj.Models;

namespace HTTProj.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {

        }

        public DbSet<Categories> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
