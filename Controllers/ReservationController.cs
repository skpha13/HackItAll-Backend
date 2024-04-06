using HackItAll_Backend.DTOs.Reservation;
using HackItAll_Backend.Models;
using HackItAll_Backend.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace HackItAll_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("_myAllowSpecificOrigins")]
    public class ReservationController : ControllerBase
    {
        private readonly ReservationService _reservationService;

        public ReservationController(ReservationService reservationService)
        {
            _reservationService = reservationService;
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _reservationService.GetAll());
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody] ReservationDto reservation)
        {
            await _reservationService.Create(reservation);
            return Ok();
        }

        [HttpPatch("update")]
        public async Task<IActionResult> Update([FromBody] Reservation reservation)
        {
            await _reservationService.Update(reservation);
            return Ok();
        }

        [HttpDelete("delete/${id}")]
        public IActionResult Delete(Guid id)
        {
            _reservationService.Delete(id);
            return Ok();
        }
    }
}
