using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using ParkService.Models;

namespace ParkService.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class UserController : ControllerBase
  {
    private ParkContext _db;

    public UserController(ParkContext db)
    {
      _db = db;
    }

    [AllowAnonymous]
    [HttpPost("register")]
    public void Register([FromBody] User user)
    {
      _db.Users.Add(user);
    }

    [AllowAnonymous]
    [HttpPost("login")]
    public IActionResult Login([FromBody] Login login)
    {
      try 
      {
        User user = _db.Users
          .Where(u => u.UserName == login.UserName)
          .First(u => u.Password == login.Password);
        string tokenString = user.BuildToken();
        return Ok(new { token = tokenString });
      }
      catch
      {
        return Unauthorized();
      }
    }
  }
}