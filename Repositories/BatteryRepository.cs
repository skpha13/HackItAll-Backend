using backend.Data;
using backend.Repositories.GenericRepository;
using HackItAll_Backend.Models;

namespace HackItAll_Backend.Repositories
{
    public class BatteryRepository : GenericRepository<Battery>
    {
        public BatteryRepository(DatabaseContext dbContext) : base(dbContext)
        {
        }
    }
}
