using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizzyAPI.Domain
{
    public class UserRole
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public virtual Role Role { get; set; }
        public int RoleId { get; set; }
    }
}