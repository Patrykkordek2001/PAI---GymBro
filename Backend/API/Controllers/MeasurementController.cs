using API.Models;
using API.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class MeasurementController : ControllerBase
    {
        private readonly IMeasurementService _measurementService;

        public MeasurementController(IMeasurementService measurementService)
        {
            _measurementService = measurementService;
        }

        [HttpGet("GetAllMeasurements")]
        public async Task<IEnumerable<Measurement>> GetAllMeasurements()
        {
            return await _measurementService.GetAllMeasurementsAsync();
        }

        [HttpGet("GetMeasurement/{id}")]
        public async Task<ActionResult<Measurement>> GetMeasurement(Guid id)
        {
            var measurement = await _measurementService.GetMeasurementByIdAsync(id);

            if (measurement == null)
            {
                return NotFound();
            }

            return measurement;
        }

        [HttpPost("AddMeasurement")]
        public async Task<ActionResult<Measurement>> AddMeasurement(Measurement measurement)
        {
            await _measurementService.AddMeasurementAsync(measurement);

            return Ok("Added new measurement");
        }

        [HttpPut("UpdateMeasurement")]
        public async Task<IActionResult> UpdateMeasurement(Measurement measurement)
        {
            await _measurementService.UpdateMeasurementAsync(measurement);

            return Ok("Updated measurement");
        }

        [HttpDelete("DeleteMeasurement/{id}")]
        public async Task<IActionResult> DeleteMeasurement(Guid id)
        {
            await _measurementService.DeleteMeasurementAsync(id);

            return Ok("Deleted measurement");
        }
    }
}
