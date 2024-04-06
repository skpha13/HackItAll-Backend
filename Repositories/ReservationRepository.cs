
using backend.Data;
using backend.Repositories.GenericRepository;
using HackItAll_Backend.Models;

namespace HackItAll_Backend.Repositories
{
    public class ReservationRepository : GenericRepository<Reservation>
    {
        public ReservationRepository(DatabaseContext dbContext) : base(dbContext)
        {
        }
    }
}
