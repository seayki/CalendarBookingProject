using BCrypt.Net;
using CalendarBooking.DomainLayer.DomainServices;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace CalendarBooking.DomainLayer.Entities
{

    [Index(nameof(UserName), IsUnique = true)]
    public class User : EntitySuperclass
    {
        private readonly IUserDomainService _userDomainService;

        [Required]
        public string UserName { get; set; } = string.Empty;

        [Required]
        public string PasswordHash { get; set; } = string.Empty;

        public User()
        {
            
        }
        public User(string userName, string password, IUserDomainService userDomainService)
        {
            _userDomainService = userDomainService;
            ValidateUserName(userName);
            ValidatePassword(password);
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(password);
            UserName = userName;
            PasswordHash = passwordHash;     
        }

        public void ValidateUserName(string userName)
        {
            if (!_userDomainService.IsUserNameUnique(userName))
            {
                throw new Exception("Username is already in use.");
            }

            if (string.IsNullOrWhiteSpace(userName))
            {
                throw new ArgumentException("Username cannot be empty.");
            }

            if (userName.Length < 4 || userName.Length > 20)
            {
                throw new ArgumentException("Username must be between 4 and 20 characters long.");
            }

            if (!Regex.IsMatch(userName, @"^[a-zA-Z0-9]+$"))
            {
                throw new ArgumentException("Username must only contain letters and numbers.");
            }
        }

        public void ValidatePassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentException("Password cannot be empty.");
            }
            if (password.Length < 8 || password.Length > 50)
            {
                throw new ArgumentException("Password must be between 8 and 50 characters long.");
            }
            if (!Regex.IsMatch(password, @"^(?=.*[A-Z])(?=.*\d)[a-zA-Z0-9]+$"))
            {
                throw new ArgumentException("Password must contain at least one uppercase letter and one number, and cannot contain special characters.");
            }
        }
    }    
}
