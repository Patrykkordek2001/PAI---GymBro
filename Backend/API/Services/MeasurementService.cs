using API.Models;
using API.Services.Interfaces;
using API.SqlRepository;

namespace API.Services
{
    public class MeasurementService : IMeasurementService
    {

        private readonly ISqlRepository<Measurement> _measurementRepository;

        public MeasurementService(ISqlRepository<Measurement> measurementRepository)
        {
            _measurementRepository = measurementRepository;
        }

        public async Task AddExcerciseAsync(Measurement measurement)
        {
            await _measurementRepository.AddAsync(measurement);
        }

        public async Task DeleteExcerciseAsync(Guid id)
        {
            await _measurementRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Measurement>> GetAllExcercisesAsync()
        {
            return await _measurementRepository.GetAllAsync();
        }

        public async Task<Measurement> GetExcerciseByIdAsync(Guid id)
        {
            return await _measurementRepository.GetByIdAsync(id);
        }

        public async Task UpdateExcerciseAsync(Measurement measurement)
        {
            await _measurementRepository.UpdateAsync(measurement);
        }

    }
}
