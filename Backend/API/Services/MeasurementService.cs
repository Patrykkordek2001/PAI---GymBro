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

        public async Task AddMeasurementAsync(Measurement measurement)
        {
            
            await _measurementRepository.AddAsync(measurement);
        }

        public async Task DeleteMeasurementAsync(Guid id)
        {
            await _measurementRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Measurement>> GetAllMeasurementsAsync()
        {
            return await _measurementRepository.GetAllAsync();
        }

        public async Task<Measurement> GetMeasurementByIdAsync(Guid id)
        {
            return await _measurementRepository.GetByIdAsync(id);
        }

        public async Task UpdateMeasurementAsync(Measurement measurement)
        {
            await _measurementRepository.UpdateAsync(measurement);
        }

    }
}
