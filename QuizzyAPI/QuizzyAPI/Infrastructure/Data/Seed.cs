using Newtonsoft.Json;
using QuizzyAPI.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizzyAPI.Infrastructure.Data
{
  public class Seed
  {
    private readonly DataContext _context;

    public Seed(DataContext context)
    {
      _context = context;
    }

    public void SeedData()
    {
      // _context.Database.EnsureCreated();
      if (_context.Users.Any() == true)
        return;

      var data = System.IO.File.ReadAllText("Infrastructure/Data/UserDataSeed.json");
      var user = JsonConvert.DeserializeObject<User>(data);

      byte[] passwordHash, passwordSalt;
      CreatePasswordHash("password", out passwordHash, out passwordSalt);

      user.PasswordHash = passwordHash;
      user.PasswordSalt = passwordSalt;
      user.Username = user.Username.ToLower();

      // _context.Users.Add(user);
      _context.UserRoles.Add(new UserRole { Role = new Role { Name = "superadmin" }, User = user });
      _context.Roles.AddRange(new List<Role> { new Role { Name = "user" }, new Role { Name = "admin" } });
      _context.SaveChanges();
    }

    private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
    {
      using (var hmac = new System.Security.Cryptography.HMACSHA512())
      {
        passwordSalt = hmac.Key;
        passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
      }
    }
  }
}
