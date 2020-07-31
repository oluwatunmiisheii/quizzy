using QuizzyAPI.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizzyAPI.Infrastructure.Services
{
    public interface IAuthRepository
    {
        Task<User> Register(User user, string password);

        Task<User> Login(string username, string password);

        Task<bool> UserExists(string username);

        Task<bool> EmailExists(string email);

        Task<IEnumerable<UserRole>> GetRoleByUserId(int id);

        Task<Role> GetRoleByName(string name);
    }
}