using backend.Models;
using backend.Repositories.TestRepository;
using HackItAll_Backend.Models;
using HackItAll_Backend.Repositories;

namespace HackItAll_Backend.Services
{
    public class ReservationService
    {
        private readonly ReservationRepository _reservationRepository;

        public ReservationService(ReservationRepository reservationRepository)
        {
            _reservationRepository = reservationRepository;
        }

        public async Task<List<Reservation>> GetAll()
        {
            return await _reservationRepository.GetAllAsync();
        }

        public async Task Create(Reservation reservation)
        {
            await _reservationRepository.CreateAsync(reservation);
            await _reservationRepository.SaveAsync();
        }

        public void Delete(Guid id)
        {
            _reservationRepository.DeleteById(id);
            _reservationRepository.SaveAsync();
        }

        public async Task Update(Reservation reservation)
        {
            _reservationRepository.Update(reservation);
            await _reservationRepository.SaveAsync();
        }
    }
}
