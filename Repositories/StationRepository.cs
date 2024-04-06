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

        public async Task<List<Station>> GetWithBatteriesAsync(Guid? modelId = null)
        {
            List<Station> stations = await _dbContext.Stations
                .Include(s => s.batteries.Where(b => (modelId == null) || (modelId == b.modelId)))
                .ThenInclude(b => b.model)
                .ToListAsync();
            return stations;
        }
    }
}
