using HackItAll_Backend.Models;
using HackItAll_Backend.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace HackItAll_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("_myAllowSpecificOrigins")]
    public class BatteryController : ControllerBase
    {
        private readonly BatteryService _batteryService;

        public BatteryController(BatteryService batteryService)
        {
            _batteryService = batteryService;
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _batteryService.GetAll());
        }

        [HttpGet("forCar")]
        public async Task<IActionResult> GetAllForCarBrandAndModel([FromQuery] string brand, [FromQuery] string model)
        {
            return Ok(await _batteryService.getForCarBrandAndModel(brand, model));
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody] Battery battery)
        {
            await _batteryService.Create(battery);
            return Ok();
        }

        [HttpPatch("update")]
        public async Task<IActionResult> Update([FromBody] Battery battery)
        {
            await _batteryService.Update(battery);
            return Ok();
        }

        [HttpDelete("delete/${id}")]
        public IActionResult Delete(Guid id)
        {
            _batteryService.Delete(id);
            return Ok();
        }
    }
}
