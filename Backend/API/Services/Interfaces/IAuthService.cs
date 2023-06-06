using API.DTO;
using API.Models;

namespace API.Services.Interfaces
{
    public interface IAuthService
    {
        Task<User?> AuthenticateUser(UserDTO userDTO);
        string HashPassword(string password);
        Task<User?> RegisterUser(User user);

        string GenerateToken();
    }
}