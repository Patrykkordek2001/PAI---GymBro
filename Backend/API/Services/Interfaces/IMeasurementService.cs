using API.Models;

namespace API.Services.Interfaces
{
    public interface IMeasurementService
    {
        Task AddMeasurementAsync(Measurement measurement);
        Task DeleteMeasurementAsync(Guid id);
        Task<IEnumerable<Measurement>> GetAllMeasurementsAsync();
        Task<Measurement> GetMeasurementByIdAsync(Guid id);
        Task UpdateMeasurementAsync(Measurement measurement);
    }
}