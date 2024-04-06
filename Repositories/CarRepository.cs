using backend.Data;
using backend.Repositories.GenericRepository;
using HackItAll_Backend.Models;

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


    }
}
