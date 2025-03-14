using Microsoft.EntityFrameworkCore;

namespace dotnet.Models
{
    public class PieShopDbContext:DbContext{
        public PieShopDbContext(DbContextOptions<PieShopDbContext> options):base(options){         
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlite("Data Source=database.db");
        }
    }
        public DbSet<Pie> Pies { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}