using API.DTO;
using API.Entities;

namespace API.Services
{
    public interface IUsersService
    {
        public void AddUser(User newUser);
        public List<User> GetAllUsers();
        public User GetUserById(int id);
    }
}
