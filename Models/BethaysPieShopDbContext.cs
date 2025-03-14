using Microsoft.EntityFrameworkCore;

namespace dotnet.Models
{
    public class PieShopDbContext:DbContext{
        public PieShopDbContext(DbContextOptions<PieShopDbContext> options):base(options){
            
        }
        public DbSet<Pie> Pies { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}