using API.Data;
using API.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using API.DTO;
using API.Services;
using API.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [AllowAnonymous]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("Register")]
        public async Task<ActionResult> Register(User user)
        {
            await _authService.RegisterUser(user);
            return Ok(new { message = "User registered" });
        }

        [HttpPost("Login")]
        public async Task<ActionResult> Login(UserDTO loginDto)
        {
            var user = await _authService.AuthenticateUser(loginDto);
            if (user == null) return Unauthorized("Wrong login or password!");
            /var jwtToken = _authService.GenerateJtwToken(user);

            return Ok(user);
        }
    }
}
