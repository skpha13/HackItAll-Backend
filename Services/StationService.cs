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
        private readonly CarRepository _carRepository;
        private readonly IMapper _mapper;

        public StationService(StationRepository stationRepository, 
            IMapper mapper,
            CarRepository carRepository)
        {
            _stationRepository = stationRepository;
            _mapper = mapper;
            _carRepository = carRepository;
        }

        public async Task<List<Station>> GetAll()
        {
             List<Station> stations = await _stationRepository.GetWithBatteriesAsync();
            return stations;
        }

        public async Task<List<StationWithBatteriesDto>> GetAllWithBatteries(string brand = null, string model = null)
        {
            Guid? batteryModelId = null;
            if(brand != null && model != null) {
                batteryModelId = await _carRepository.getBatteryModel(brand, model);
            }
            List<Station> stations = await _stationRepository.GetWithBatteriesAsync(batteryModelId);
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
