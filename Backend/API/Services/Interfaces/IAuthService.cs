using API.DTO;
using API.Models;

namespace API.Services.Interfaces
{
    public interface IAuthService
    {
        Task<User?> AuthenticateUser(UserDTO loginDto);
        string HashPassword(string password);
        Task<User?> RegisterUser(User user);
    }
}
