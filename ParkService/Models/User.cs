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

    public User(string userName, string password)
    {
      this.UserName = userName;
      this.Password = password;
    }

    public string BuildToken(string stringkey, string issuer)
    {
      SymmetricSecurityKey key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(stringkey));
      SigningCredentials creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

      JwtSecurityToken token = new JwtSecurityToken(issuer,
        issuer,
        expires: DateTime.Now.AddMinutes(30),
        signingCredentials: creds);

      return new JwtSecurityTokenHandler().WriteToken(token);
    }
  }
}