using API.Models;

namespace API.Services.Interfaces
{
    public interface IExcerciseService
    {
        Task AddExcerciseAsync(Excercise excercise);
        Task DeleteExcerciseAsync(Guid id);
        Task<IEnumerable<Excercise>> GetAllExcercisesAsync();
        Task<Excercise> GetExcerciseByIdAsync(Guid id);
        Task UpdateExcerciseAsync(Excercise excercise);
    }
}