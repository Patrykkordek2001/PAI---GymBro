using API.Models;

namespace API.Services.Interfaces
{
    public interface IWorkoutService
    {
        Task AddWorkoutAsync(Workout workout);
        Task DeleteWorkoutAsync(Guid id);
        Task<IEnumerable<Workout>> GetAllWorkoutsAsync();
        Task<Workout> GetWorkoutByIdAsync(Guid id);
        Task UpdateWorkoutAsync(Workout workout);
    }
}