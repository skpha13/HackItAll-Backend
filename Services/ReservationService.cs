using AutoMapper;
using backend.Models;
using HackItAll_Backend.DTOs.Reservation;
using HackItAll_Backend.Models;
using HackItAll_Backend.Repositories;

namespace HackItAll_Backend.Services
{
    public class ReservationService
    {
        private readonly ReservationRepository _reservationRepository;
        private readonly IMapper _mapper;

        public ReservationService(
            ReservationRepository reservationRepository,
            IMapper mapper
            )
        {
            _reservationRepository = reservationRepository;
            _mapper = mapper;
        }

        public async Task<List<Reservation>> GetAll()
        {
            return await _reservationRepository.GetAllAsync();
        }

        public async Task Create(ReservationDto dto)
        {
            Reservation reservation = _mapper.Map<Reservation>(dto);
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
