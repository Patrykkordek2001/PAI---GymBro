using API.Models;
using API.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExcerciseController : ControllerBase
    {
        private readonly IExcerciseService _excerciseService;

        public ExcerciseController(IExcerciseService excerciseService)
        {
            _excerciseService = excerciseService;
        }

        [HttpGet("GetAllExcercises")]
        public async Task<IEnumerable<Excercise>> GetAllExcercises()
        {
            return await _excerciseService.GetAllExcercisesAsync();
        }

        [HttpGet("GetHour/{id}")]
        public async Task<ActionResult<Excercise>> GetExcercise(Guid id)
        {
            var excercise = await _excerciseService.GetExcerciseByIdAsync(id);

            if (excercise == null)
            {
                return NotFound();
            }

            return excercise;
        }

        [HttpPost("AddExcercise")]
        public async Task<ActionResult<Excercise>> AddExcercise(Excercise excercise)
        {
            await _excerciseService.AddExcerciseAsync(excercise);

            return Ok("Added new excercise");
        }

        [HttpPut("UpdateExcercise")]
        public async Task<IActionResult> UpdateExcercise(Excercise excercise)
        {
            await _excerciseService.UpdateExcerciseAsync(excercise);

            return Ok("Updated excercise");
        }

        [HttpDelete("DeleteExcercise/{id}")]
        public async Task<IActionResult> DeleteExcercise(Guid id)
        {
            await _excerciseService.DeleteExcerciseAsync(id);

            return Ok("Deleted excercise");
        }
    }
}
