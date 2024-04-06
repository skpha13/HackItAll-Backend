using AutoMapper;
using backend.Models;
using HackItAll_Backend.DTOs.Station;
using HackItAll_Backend.Models;
using HackItAll_Backend.Repositories;

namespace HackItAll_Backend.Services
{
    public class StationService
    {
        private readonly StationRepository _stationRepository;
        private readonly IMapper _mapper;

        public StationService(StationRepository stationRepository, 
            IMapper mapper)
        {
            _stationRepository = stationRepository;
            _mapper = mapper;
        }

        public async Task<List<Station>> GetAll()
        {
             List<Station> stations = await _stationRepository.GetWithBatteriesAsync();
            return stations;
        }

        public async Task<List<StationWithBatteriesDto>> GetAllWithBatteries()
        {
            List<Station> stations = await _stationRepository.GetWithBatteriesAsync();
            return _mapper.Map<List<StationWithBatteriesDto>>(stations);
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
