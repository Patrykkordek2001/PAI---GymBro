using API.Data;
using API.DTO;
using API.Entities;
using Microsoft.AspNetCore.DataProtection.Repositories;
using Microsoft.EntityFrameworkCore;

namespace API.Services
{
    public class UsersService: IUsersService
    {
        private readonly DataContext _dbContext;


        public UsersService( DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddUser(User newUser)
        {
            try
            {
                _dbContext.Users.Add(newUser);
                _dbContext.SaveChanges();
                Console.WriteLine("Użytkownik dodany pomyślnie!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Wystąpił błąd podczas dodawania użytkownika: {ex.Message}");
            }
        }

        public List<User> GetAllUsers()
        {
            return _dbContext.Users.AsNoTracking().ToList();
        }

        public User GetUserById(int id)
        {
            return _dbContext.Users.AsNoTracking().FirstOrDefault(u => u.Id == id);
        }

    }
}
