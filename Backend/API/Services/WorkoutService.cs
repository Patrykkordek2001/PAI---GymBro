using API.Models;
using API.Services.Interfaces;
using API.SqlRepository;
using System.Diagnostics.Metrics;

namespace API.Services
{
    public class WorkoutService : IWorkoutService
    {

        private readonly ISqlRepository<Workout> _workoutRepository;

        public WorkoutService(ISqlRepository<Workout> workoutRepository)
        {
            _workoutRepository = workoutRepository;
        }

        public async Task AddWorkoutAsync(Workout workout)
        {
            workout.UserID = new Guid("8BD39627-0A1F-4E5F-4745-08DB6B25AAAA");
            await _workoutRepository.AddAsync(workout);
        }

        public async Task DeleteWorkoutAsync(Guid id)
        {
            await _workoutRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Workout>> GetAllWorkoutsAsync()
        {
            return await _workoutRepository.GetAllAsync();
        }

        public async Task<Workout> GetWorkoutByIdAsync(Guid id)
        {
            return await _workoutRepository.GetByIdAsync(id);
        }

        public async Task UpdateWorkoutAsync(Workout workout)
        {
            await _workoutRepository.UpdateAsync(workout);
        }

    }
}
