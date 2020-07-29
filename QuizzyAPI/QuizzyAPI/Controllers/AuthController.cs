using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using QuizzyAPI.Domain;
using QuizzyAPI.Dtos;
using QuizzyAPI.Services;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace QuizzyAPI.Controllers
{
    [ApiController]
    [Route("api/auth/")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _repository;

        private readonly IConfiguration _configuration;

        public AuthController(IAuthRepository repository, IConfiguration configuration)
        {
            _repository = repository;
            _configuration = configuration;
        }

        /// <summary>
        /// Use to Register to become a member
        /// </summary>
        /// <param name="userforRegisterDto"> object that collects user information</param>
        /// <returns>returns a created user</returns>
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        [HttpPost("register")]
        public async Task<IActionResult> Register(UserForRegisterDto userforRegisterDto)
        {
            if (await _repository.UserExists(userforRegisterDto.Username.ToLower()))
                ModelState.AddModelError("Username", "Username already exist");

            if (await _repository.EmailExists(userforRegisterDto.Email.ToLower()))
                ModelState.AddModelError("Email", "Email already exist");

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            userforRegisterDto.Username = userforRegisterDto.Username.ToLower();

            //if (await _repository.UserExists(userforRegisterDto.Username))
            //    return BadRequest("Username is already taken ");

            var userToCreate = new User
            {
                Username = userforRegisterDto.Username,
                LastName = userforRegisterDto.LastName.ToLower(),
                FirstName = userforRegisterDto.LastName.ToLower(),
                Email = userforRegisterDto.Email.ToLower(),
            };
            var createUser = await _repository.Register(userToCreate, userforRegisterDto.Password);
            var createdUser = new CreatedUser { Email = createUser.Email, FirstName = createUser.FirstName, Id = createUser.Id, LastName = createUser.LastName, Username = createUser.Username };
            return StatusCode(201, new { user = createdUser });
        }

        [HttpPost("login")]
        [ProducesResponseType(400)]
        public async Task<IActionResult> Login(UserForLoginDto userForLoginDto)
        {
            var userFromRepo = await _repository.Login(userForLoginDto.Username, userForLoginDto.Password);
            if (userFromRepo == null)
                return Unauthorized();

            var roles = await _repository.GetRoleByUserId(userFromRepo.Id);

            //generate token
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes((_configuration.GetSection("AppSettings:key").Value));
            // var checkkey = Convert.FromBase64String("super secret key");
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new System.Security.Claims.ClaimsIdentity(new Claim[]
                 {
                     new Claim(ClaimTypes.NameIdentifier, userFromRepo.FirstName),
                     new Claim(ClaimTypes.Name, userFromRepo.Username),
                     new Claim("role",roles.FirstOrDefault().Role.Name)
                    // new Claim("Role")
                 }),
                Expires = DateTime.Now.AddDays(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha512Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenString = tokenHandler.WriteToken(token);
            return Ok(new { tokenString });
        }
    }
}