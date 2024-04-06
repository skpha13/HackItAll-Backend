using backend.Data;
using backend.Repositories.GenericRepository;
using HackItAll_Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace HackItAll_Backend.Repositories
{
    public class StationRepository : GenericRepository<Station>
    {
        public StationRepository(DatabaseContext dbContext) : base(dbContext)
        {
        }

        public async Task<List<Station>> GetWithBatteriesAsync()
        {
            List<Station> stations = await _dbContext.Stations
                .Include(s => s.batteries)
                .ThenInclude(b => b.model)
                .ToListAsync();
            return stations;
        }
    }
}
