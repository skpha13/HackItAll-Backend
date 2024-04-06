
using HackItAll_Backend.Models;
using HackItAll_Backend.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace HackItAll_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("_myAllowSpecificOrigins")]
    public class ModelController : ControllerBase
    {
        private readonly ModelService _modelService;

        public ModelController(ModelService modelService  )
        {
            _modelService = modelService;
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _modelService.GetAll());
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody] Model model)
        {
            await _modelService.Create(model);
            return Ok();
        }

        [HttpPatch("update")]
        public async Task<IActionResult> Update([FromBody] Model model)
        {
            await _modelService.Update(model);
            return Ok();
        }

        [HttpDelete("delete/${id}")]
        public IActionResult Delete(Guid id)
        {
            _modelService.Delete(id);
            return Ok();
        }
    }
}
