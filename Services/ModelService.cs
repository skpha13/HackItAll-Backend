using backend.Models;
using backend.Repositories.TestRepository;
using HackItAll_Backend.Models;
using HackItAll_Backend.Repositories;
using Swashbuckle.AspNetCore.SwaggerUI;

namespace HackItAll_Backend.Services
{
    public class ModelService
    {
        private readonly ModelRepository _modelRepository;

        public ModelService(ModelRepository modelRepository)
        {
            _modelRepository = modelRepository;
        }

        public async Task<List<Model>> GetAll()
        {
            return await _modelRepository.GetAllAsync();
        }

        public async Task Create(Model model)
        {
            await _modelRepository.CreateAsync(model);
            await _modelRepository.SaveAsync();
        }

        public void Delete(Guid id)
        {
            _modelRepository.DeleteById(id);
            _modelRepository.SaveAsync();
        }

        public async Task Update(Model model)
        {
            _modelRepository.Update(model);
            await _modelRepository.SaveAsync();
        }
    }
}
