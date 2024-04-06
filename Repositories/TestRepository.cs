using backend.Data;
using backend.Repositories.GenericRepository;
using HackItAll_Backend.Models;

namespace HackItAll_Backend.Repositories
{
    public class TestRepository : GenericRepository<Station>
    {
        public TestRepository(DatabaseContext dbContext) : base(dbContext)
        {
        }
    }
}
