using backend.Data;
using backend.Repositories.GenericRepository;
using HackItAll_Backend.Models;

namespace HackItAll_Backend.Repositories
{
    public class StationRepository : GenericRepository<Station>
    {
        public StationRepository(DatabaseContext dbContext) : base(dbContext)
        {
        }
    }
}
