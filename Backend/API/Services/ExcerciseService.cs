using API.Models;
using API.Services.Interfaces;
using API.SqlRepository;

namespace API.Services
{
    public class ExcerciseService :  IExcerciseService
    {

        private readonly ISqlRepository<Excercise> _excerciseRepository;

        public ExcerciseService(ISqlRepository<Excercise> excerciseRepository)
        {
            _excerciseRepository = excerciseRepository;
        }

        public async Task AddExcerciseAsync(Excercise excercise)
        {
            await _excerciseRepository.AddAsync(excercise);
        }

        public async Task DeleteExcerciseAsync(Guid id)
        {
            await _excerciseRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Excercise>> GetAllExcercisesAsync()
        {
            return await _excerciseRepository.GetAllAsync();
        }

        public async Task<Excercise> GetExcerciseByIdAsync(Guid id)
        {
            return await _excerciseRepository.GetByIdAsync(id);
        }

        public async Task UpdateExcerciseAsync(Excercise excercise)
        {
            await _excerciseRepository.UpdateAsync(excercise);
        }

    }
}
