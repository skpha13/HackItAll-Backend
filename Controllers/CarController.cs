using backend.Models;
using backend.Services.TestService;
using HackItAll_Backend.DTOs.Car;
using HackItAll_Backend.Models;
using HackItAll_Backend.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace HackItAll_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("_myAllowSpecificOrigins")]
    public class CarControlller : ControllerBase
    {
        private readonly CarService _carService;

        public CarControlller(CarService carService)
        {
            _carService = carService;
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _carService.GetAll());
        }

        [HttpGet("brands")]
        public async Task<IActionResult> GetBrands()
        {
            return Ok(await _carService.GetBrands());
        }

        [HttpGet("models")]
        public async Task<IActionResult> GetModels([FromQuery] string brand)
        {
            return Ok(await _carService.GetModels(brand));
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody] Car car)
        {
            await _carService.Create(car);
            return Ok();
        }

        [HttpPatch("update")]
        public async Task<IActionResult> Update([FromBody] Car car)
        {
            await _carService.Update(car);
            return Ok();
        }

        [HttpDelete("delete/${id}")]
        public IActionResult Delete(Guid id)
        {
            _carService.Delete(id);
            return Ok();
        }
    }
}
