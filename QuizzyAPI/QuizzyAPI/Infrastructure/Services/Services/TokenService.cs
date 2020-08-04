using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace QuizzyAPI.Infrastructure.Services.Services
{
    public class TokenService : ITokenService
    {
        private readonly IConfiguration _configuration;

        public TokenService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GenerateAccessToken(IEnumerable<Claim> claims)
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Data:Tokens:SecretKey"]));
            var jwtToken = new JwtSecurityToken(
                issuer: _configuration["Data:Tokens:Issuer"],
                 audience: _configuration["Data:Tokens:Issuer"],
                 claims: claims,
                 expires: DateTime.UtcNow.AddMinutes(int.Parse(_configuration["Data:Tokens:TokenExpiry"])),
                 signingCredentials: new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature));

            return new JwtSecurityTokenHandler().WriteToken(jwtToken);
        }
    }
}