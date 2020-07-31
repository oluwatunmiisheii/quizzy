using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using QuizzyAPI.Domain;

namespace QuizzyAPI.Infrastructure.Services
{
    public class AuthRepository : IAuthRepository
    {
        private readonly DataContext _dataContext;

        public AuthRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<User> Login(string username, string password)
        {
            var user = await _dataContext.Users.FirstOrDefaultAsync(x => x.Username == username);
            if (user == null)
            {
                user = await _dataContext.Users.FirstOrDefaultAsync(x => x.Email == username);
                if (user == null) return null;
            }
            if (!VerifyPassword(password, user.PasswordHash, user.PasswordSalt)) return null;
            return user;
        }

        private bool VerifyPassword(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != passwordHash[i]) return false;
                }
            }
            return true;
        }

        public async Task<User> Register(User user, string password)
        {
            byte[] passwordHash, passwordSalt;
            CreatePasswordHash(password, out passwordHash, out passwordSalt);
            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;

            var role = await _dataContext.Roles.FirstOrDefaultAsync(c => c.Name == "user");

            await _dataContext.UserRoles.AddAsync(new UserRole { Role = role, User = user });
            await _dataContext.SaveChangesAsync();
            return user;
        }

        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            //using using so 2
            using (var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }

        public async Task<IEnumerable<UserRole>> GetRoleByUserId(int id)
        {
            var ans = _dataContext.UserRoles.Include(c => c.Role).Where(c => c.UserId == id);
            return await Task.FromResult(ans);
        }

        public async Task<Role> GetRoleByName(string name)
        {
            var ans = await _dataContext.Roles.FirstOrDefaultAsync(c => c.Name == name.ToLower());
            return ans;
        }

        public async Task<bool> UserExists(string username)
        {
            if (await _dataContext.Users.AnyAsync(x => x.Username == username)) return true;
            return false;
        }

        public async Task<bool> EmailExists(string email)
        {
            if (await _dataContext.Users.AnyAsync(x => x.Email == email)) return true;
            return false;
        }
    }
}