using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Linq;
using ParkService.Models;

namespace ParkService.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class UserController : ControllerBase
  {
    private ParkContext _db;
    private IConfiguration _config;

    public UserController(ParkContext db, IConfiguration config)
    {
      _db = db;
      _config = config;
    }

    [AllowAnonymous]
    [HttpPost("register")]
    public void Register([FromBody] User user)
    {
      _db.Users.Add(user);
      _db.SaveChanges();
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
        string key = _config["Jwt:Key"];
        string issuer = _config["Jwt:Issuer"];
        string tokenString = user.BuildToken(key, issuer);
        return Ok(new { token = tokenString });
      }
      catch
      {
        return Unauthorized();
      }
    }
  }
}