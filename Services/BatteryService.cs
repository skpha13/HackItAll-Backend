using AutoMapper;
using backend.Models;
using HackItAll_Backend.DTOs.Battery;
using HackItAll_Backend.DTOs.Station;
using HackItAll_Backend.Models;
using HackItAll_Backend.Repositories;

namespace HackItAll_Backend.Services
{
    public class BatteryService
    {
        private readonly BatteryRepository _batteryRepository;
        private readonly CarRepository _carRepository;
        private readonly IMapper _mapper;

        public BatteryService(
            BatteryRepository batteryRepository, 
            CarRepository carRepository,
            IMapper mapper)
        {
            _carRepository = carRepository;
            _batteryRepository = batteryRepository;
            _mapper  = mapper;
        }

        public async Task<List<Battery>> GetAll()
        {
            return await _batteryRepository.GetAllAsync();
        }

        public async Task Create(Battery battery)
        {
            await _batteryRepository.CreateAsync(battery);
            await _batteryRepository.SaveAsync();
        }

        public void Delete(Guid id)
        {
            _batteryRepository.DeleteById(id);
            _batteryRepository.SaveAsync();
        }

        public async Task Update(Battery battery)
        {
            _batteryRepository.Update(battery);
            await _batteryRepository.SaveAsync();
        }

        public async Task<List<BatteryWithStationDto>> getForCarBrandAndModel(string brand, string model)
        {
            Guid batteryModelId = await _carRepository.getBatteryModel(brand, model);
            List<Battery> batteries = await _batteryRepository.getForModelId(batteryModelId);
            return _mapper.Map<List<BatteryWithStationDto>>(batteries).ToList();
        }
    }
}
