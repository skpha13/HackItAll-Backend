
using HackItAll_Backend.Models;
using HackItAll_Backend.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace HackItAll_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("_myAllowSpecificOrigins")]
    public class StationController : ControllerBase
    {
        private readonly StationService _stationService;

        public StationController(StationService stationService)
        {
            _stationService = stationService;
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAll(string brand = null, string model = null)
        {
            return Ok(await _stationService.GetAllWithBatteries(brand, model));
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody] Station station)
        {
            await _stationService.Create(station);
            return Ok();
        }

        [HttpPatch("update")]
        public async Task<IActionResult> Update([FromBody] Station station)
        {
            await _stationService.Update(station);
            return Ok();
        }

        [HttpDelete("delete/${id}")]
        public IActionResult Delete(Guid id)
        {
            _stationService.Delete(id);
            return Ok();
        }
    }
}
