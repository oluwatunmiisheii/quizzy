using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuizzyAPI.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Kindly input valid Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(15, MinimumLength = 6, ErrorMessage = "Password must be between 7 and 15 characters")]
        public string Password { get; set; }

        [Required]
        [StringLength(8, MinimumLength = 2, ErrorMessage = "You must specify a password between 4 and 8 characters")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(8, MinimumLength = 2, ErrorMessage = "You must specify a password between 4 and 8 characters")]
        public string LastName { get; set; }
    }

    public class CreatedUser
    {
        public int Id { get; set; }
        public string Username { get; set; }

        public string Email { get; set; }


        public string FirstName { get; set; }

        public string LastName { get; set; }
    }




}