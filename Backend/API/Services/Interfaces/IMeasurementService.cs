using API.Models;

namespace API.Services.Interfaces
{
    public interface IMeasurementService
    {
        Task AddExcerciseAsync(Measurement measurement);
        Task DeleteExcerciseAsync(Guid id);
        Task<IEnumerable<Measurement>> GetAllExcercisesAsync();
        Task<Measurement> GetExcerciseByIdAsync(Guid id);
        Task UpdateExcerciseAsync(Measurement measurement);
    }
}