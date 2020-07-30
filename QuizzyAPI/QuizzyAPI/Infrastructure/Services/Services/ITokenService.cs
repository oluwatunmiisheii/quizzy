using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Claims;

namespace QuizzyAPI.Infrastructure.Services.Services
{
    public interface ITokenService
    {
        string GenerateAccessToken(IEnumerable<Claim> claims);
    }
}