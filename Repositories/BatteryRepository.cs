using backend.Data;
using backend.Repositories.GenericRepository;
using HackItAll_Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace HackItAll_Backend.Repositories
{
    public class BatteryRepository : GenericRepository<Battery>
    {
        public BatteryRepository(DatabaseContext dbContext) : base(dbContext)
        {
        }

        public async Task<List<Battery>> getForModelId(Guid guid)
        {
            return await _table.Where(b => b.modelId == guid)
                .Include(b => b.model)
                .Include(b => b.station)
                .Include(b => b.reservation)
                .ToListAsync();
        }

        public new async Task<List<Battery>> GetAllAsync()
        {
            return await _table
                .Include(b => b.model)
                .Include(b => b.station)
                .ToListAsync();
        }
    }
}
