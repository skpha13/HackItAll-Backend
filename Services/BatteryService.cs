using backend.Models;
using HackItAll_Backend.Models;
using HackItAll_Backend.Repositories;

namespace HackItAll_Backend.Services
{
    public class BatteryService
    {
        private readonly BatteryRepository _batteryRepository;

        public BatteryService(BatteryRepository batteryRepository)
        {
            _batteryRepository = batteryRepository;
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
    }
}
