using API.Models;

namespace API.Services.Interfaces
{
    public interface IUserService
    {
        Task AddUserAsync(User user);
        Task DeleteUserAsync(Guid id);
        Task<IEnumerable<User>> GetAllUsersAsync();
        Task<User> GetUserByIdAsync(Guid id);
        Task UpdateUserAsync(User user);
    }
}