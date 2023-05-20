using API.Data;
using API.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using API.DTO;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly DataContext _dbContext;

        public AuthController(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            var users = await _dbContext.Users.ToListAsync();
            return Ok(users);
        }

        [HttpPost("register")]
        public async Task<ActionResult<User>> Register(User model)
        {
            if (await _dbContext.Users.AnyAsync(u => u.UserName == model.UserName))
            {
                return BadRequest("Username already exists");
            }
`
            var user = new User
            {
                Name= model.Name,
                UserName = model.UserName,
                Email = model.Email,
                Password = model.Password
            };

            _dbContext.Users.Add(user);
            await _dbContext.SaveChangesAsync();

            return Ok(user);
        }

        [HttpPost("login")]
        public async Task<ActionResult<User>> Login(UserDTO userDTO)
        {
            var user = await _dbContext.Users.FirstOrDefaultAsync(u => u.UserName == userDTO.UserName && u.Password == userDTO.Password);

            if (user == null)
            {
                return BadRequest("Nieprawidłowa nazwa użytkownika lub hasło");
            }

            return Ok(user);
        }
    }
}
