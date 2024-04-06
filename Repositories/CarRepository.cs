using backend.Data;
using backend.Repositories.GenericRepository;
using HackItAll_Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace HackItAll_Backend.Repositories
{
    public class CarRepository : GenericRepository<Car>
    {
        public CarRepository(DatabaseContext dbContext) : base(dbContext)
        {
        }

        public List<string> getBrands()
        {
            return _dbContext.Cars.Select(c => c.brand).Distinct().ToList();
        }

        public List<string> getModels(string brand)
        {
            return _dbContext.Cars.Where(c => EF.Functions.Like(c.brand.ToLower(), brand.ToLower())).Select(c => c.model).Distinct().ToList();
        }
    }
}
