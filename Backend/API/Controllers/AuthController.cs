using API.Data;
using API.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using API.DTO;
using API.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Security.Cryptography;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [AllowAnonymous]
    public class AuthController : ControllerBase
    {
        private readonly IUserService _usersService;
        private readonly IAuthService _authService;
        private readonly IConfiguration _configuration;

        public AuthController(IAuthService authService, IConfiguration configuration, IUserService userService )
        {
            _usersService = userService;
            _configuration = configuration;
            _authService = authService;

        }


        [HttpPost("Register")]
        public async Task<ActionResult> Register(User user)
        {
            await _authService.RegisterUser(user);
            return Ok(new { message = "User registered" });
        }

        [HttpPost("Login")]
        public async Task<ActionResult> Login(UserDTO userDTO)
            {

            var user = await _authService.AuthenticateUser(userDTO);
            if (user == null) return Unauthorized("Wrong login or password!");
            var jwtToken = _authService.GenerateToken();

            return Ok(new { token = jwtToken });
        }
    }
}
