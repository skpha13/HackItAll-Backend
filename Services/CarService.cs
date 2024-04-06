using AutoMapper;
using backend.Models;
using HackItAll_Backend.DTOs.Car;
using HackItAll_Backend.Models;
using HackItAll_Backend.Repositories;

namespace HackItAll_Backend.Services
{
    public class CarService
    {
        private readonly CarRepository _carRepository;
        private readonly IMapper _mapper;

        public CarService(CarRepository carRepository, IMapper  mapper)
        {
            _carRepository = carRepository;
            _mapper = mapper;
        }

        public async Task<List<Car>> GetAll()
        {
            return await _carRepository.GetAllAsync();
        }

        public async Task Create(Car car)
        {
            await _carRepository.CreateAsync(car);
            await _carRepository.SaveAsync();
        }

        public void Delete(Guid id)
        {
            _carRepository.DeleteById(id);
            _carRepository.SaveAsync();
        }

        public async Task Update(Car car)
        {
            _carRepository.Update(car);
            await _carRepository.SaveAsync();
        }

        public async Task<List<CarBrandDto>> GetBrands()
        {
            List<string> brands = _carRepository.getBrands();
            return _mapper.Map<List<CarBrandDto>>(brands);
        }

        public async Task<List<CarModelDto>> GetModels(string brand)
        {
            List<string> models = _carRepository.getModels(brand);
            return _mapper.Map<List<CarModelDto>>(models);
        }
    }
}
