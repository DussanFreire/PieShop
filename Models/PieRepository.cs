
using Microsoft.EntityFrameworkCore;

namespace dotnet.Models
{
    public class PieRepository : IPieRepository
    {
        private readonly PieShopDbContext _pieShopDbContext;
        public PieRepository(PieShopDbContext pieShopDbContext)
        {
            _pieShopDbContext = pieShopDbContext;
        }
        public IEnumerable<Pie> AllPies {
            get {
                return _pieShopDbContext.Pies.Include(c => c.Category);
            }
        }

        public IEnumerable<Pie> PiesOfTheWeek {
            get {
                return AllPies.Where(p => p.IsPieOfTheWeek);
            }
        }
        public Pie? GetPieById(int pieId)
        {
            return _pieShopDbContext.Pies.FirstOrDefault(p=> p.PieId == pieId);
        }
    }
}