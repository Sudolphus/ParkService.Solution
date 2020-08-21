using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ParkService.Models
{
  public class User
  {
    public int UserId { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public bool Admin { get; set; }

    public User(string userName, string password, bool admin = false)
    {
      this.UserName = userName;
      this.Password = password;
      this.Admin = admin;
    }

    public string BuildToken(string stringkey, string issuer)
    {
      SymmetricSecurityKey key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(stringkey));
      SigningCredentials creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
      var claims = new List<Claim> {
        new Claim(JwtRegisteredClaimNames.Sub, this.UserName),
        new Claim(ClaimTypes.Role, "User")
      };
      if (this.Admin)
      {
        claims.Add(new Claim(ClaimTypes.Role, "Admin"));
      }

      JwtSecurityToken token = new JwtSecurityToken(issuer,
        issuer,
        claims: claims,
        expires: DateTime.Now.AddMinutes(30),
        signingCredentials: creds);

      return new JwtSecurityTokenHandler().WriteToken(token);
    }
  }
}