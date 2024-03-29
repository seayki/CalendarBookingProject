﻿using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace CalendarBooking.DomainLayer.Entities
{
    public class Student : EntitySuperclass
    {
        [Required]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        public string LastName { get; set; } = string.Empty;

        public string? Email { get; set; }

        public List<Booking> Bookings { get; set; } = new();
        public List<Group> Groups { get; set; } = new List<Group>();

        [Required]
        public User User { get; set; } = new();

        public Student()
        {
          
        }

        public Student(string firstName, string lastName, User user)
        {
            FirstName = firstName;
            LastName = lastName;
            Validate();    
            User = user;
        }

        public void Validate()
        {
            if (string.IsNullOrWhiteSpace(this.FirstName)) 
            {
                throw new ArgumentException("Firstname cannot be empty.");
            }

            if (string.IsNullOrWhiteSpace(this.LastName))
            {
                throw new ArgumentException("LastName cannot be empty.");
            }

            if (!Regex.IsMatch(this.FirstName, @"^[a-zA-Z]+$"))
            {
                throw new ArgumentException("Firstname can only contain letters.");
            }

            if (!Regex.IsMatch(this.LastName, @"^[a-zA-Z]+$"))
            {
                throw new ArgumentException("Lastname can only contain letters.");
            }
        }
    }
}