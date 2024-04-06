using backend.Data;
using backend.Repositories.GenericRepository;
using HackItAll_Backend.Models;

namespace HackItAll_Backend.Repositories
{
    public class ModelRepository : GenericRepository<Model>
    {
        public ModelRepository(DatabaseContext dbContext) : base(dbContext)
        {
        }
    }
}
