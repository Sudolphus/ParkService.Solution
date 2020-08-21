using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace ParkService.Models
{
  public class User
  {
    public int UserId { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    private IConfiguration _config;
    public User(string userName, string password, IConfiguration config)
    {
      this.UserName = userName;
      this.Password = password;
      this._config = config;
    }

    public string BuildToken()
    {
      SymmetricSecurityKey key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
      SigningCredentials creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

      JwtSecurityToken token = new JwtSecurityToken(_config["Jwt:Issuer"],
        _config["Jwt:Issuer"],
        expires: DateTime.Now.AddMinutes(30),
        signingCredentials: creds);

      return new JwtSecurityTokenHandler().WriteToken(token);
    }
  }
}