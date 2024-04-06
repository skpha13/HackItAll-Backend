using backend.Models;
using backend.Repositories.TestRepository;
using HackItAll_Backend.Models;
using HackItAll_Backend.Repositories;

namespace HackItAll_Backend.Services
{
    public class StationService
    {
        private readonly StationRepository _stationRepository;

        public StationService(StationRepository stationRepository)
        {
            _stationRepository = stationRepository;
        }

        public async Task<List<Station>> GetAll()
        {
            return await _stationRepository.GetAllAsync();
        }

        public async Task Create(Station station)
        {
            await _stationRepository.CreateAsync(station);
            await _stationRepository.SaveAsync();
        }

        public void Delete(Guid id)
        {
            _stationRepository.DeleteById(id);
            _stationRepository.SaveAsync();
        }

        public async Task Update(Station station)
        {
            _stationRepository.Update(station);
            await _stationRepository.SaveAsync();
        }
    }
}
