using API.Data;
using API.Entities;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using API.Services;
using System.Security.Cryptography;
using API.DTO;
using Microsoft.AspNetCore.Authorization;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly DataContext _dbContext;
        private readonly IConfiguration _configuration;
        private readonly IUsersService _usersService;


        public AuthController(DataContext dbContext,IConfiguration configuration,IUsersService usersService)
        {
            _dbContext = dbContext;
            _configuration = configuration;
            _usersService = usersService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            var users = await _dbContext.Users.ToListAsync();
            return Ok(users);
        }

        
        

        [AllowAnonymous]
        [HttpPost("Register")]
        public IActionResult Register(User user)
        {
            var users = _usersService.GetAllUsers();
            var passwordHash = HashPassword(user.Password);
            var userExists = users.FirstOrDefault(u => u.UserName == user.UserName && u.Password == user.Password);

            if (userExists == null)
            {
                _usersService.AddUser(user);
            }

            return Ok(user);
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public IActionResult Login(LoginDTO user)
        {
            IActionResult response = Unauthorized();
            var user_ = AuthenticateUser(user);
            if (user_ != null)
            {
                var token = GenerateToken(user_);
                response = Ok(new { token });
            }
            return response;
        }

        private string GenerateToken(User user)
        {
            var key = Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]);

            var userIdClaim = new Claim("userId", user.Id.ToString());

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Issuer = _configuration["Jwt:Issuer"],
                Audience = _configuration["Jwt:Audience"],
                Expires = DateTime.UtcNow.AddDays(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature),
                Subject = new ClaimsIdentity(new[] { userIdClaim })
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }

        private static string HashPassword(string password)
        {
            using var sha256 = SHA256.Create();
            var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
        }

        private User? AuthenticateUser(LoginDTO user)
        {
            var users = _usersService.GetAllUsers();

            var authenticatedUser = users.FirstOrDefault
                (u => u.UserName == user.UserName && u.Password == HashPassword(user.Password)); //TODO

            if (authenticatedUser != null)
            {
                return authenticatedUser;
            }
            else
            {
                return null;
            }
        }



    }
}
