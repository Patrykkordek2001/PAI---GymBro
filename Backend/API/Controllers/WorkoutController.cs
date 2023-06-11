using API.Models;
using API.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class WorkoutController : ControllerBase
    {
        private readonly IWorkoutService _workoutService;

        public WorkoutController(IWorkoutService hoursService)
        {
            _workoutService = hoursService;
        }

        [HttpGet("GetAllWorkouts")]
        public async Task<IEnumerable<Workout>> GetAllWorkouts()
        {
            return await _workoutService.GetAllWorkoutsAsync();
        }

        [HttpGet("GetHour/{id}")]
        public async Task<ActionResult<Workout>> GetHour(Guid id)
        {
            var hour = await _workoutService.GetWorkoutByIdAsync(id);

            if (hour == null)
            {
                return NotFound();
            }

            return hour;
        }

        [HttpPost("AddWorkout")]
        public async Task<ActionResult<Workout>> AddWorkout(Workout workout)
        {
            await _workoutService.AddWorkoutAsync(workout);


            return Ok(new { message = "Added new workout" });
        }

        [HttpPut("UpdateWorkout")]
        public async Task<IActionResult> UpdateWorkout(Workout workout)
        {
            await _workoutService.UpdateWorkoutAsync(workout);

            return Ok(new { message = "Updated workout" });
        }

        [HttpDelete("DeleteWorkout/{id}")]
        public async Task<IActionResult> DeleteWorkout(Guid id)
        {
            await _workoutService.DeleteWorkoutAsync(id);

            return Ok(new { message = "Deleted workout" });
        }
    }
}
