using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GymBro.API.Controllers
{
  [Route("api/[controller]")]
  public class UsersController : Controller
  {
    [HttpPost("register")]
    public async Task<IActionResult> Register()
    {
      return Ok();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetUserById()
    {
      return Ok();
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateUser()
    {

      return Ok();
    }


  }
}
