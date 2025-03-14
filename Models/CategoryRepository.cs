namespace dotnet.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly PieShopDbContext _pieShopDbContext;
        public CategoryRepository(PieShopDbContext PieShopDbContext)
        {
            _pieShopDbContext = PieShopDbContext;
        }
        public IEnumerable<Category> AllCategories {
            get {
                return _pieShopDbContext.Categories.OrderBy(c=> c.CategoryName);
            }
        }
      
    }
}