using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace CalendarBooking.DomainLayer.Entities
{
    public class Teacher : EntitySuperclass
    {
        [Required]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        public string LastName { get; set; } = string.Empty;
        public List<Timeslot> Timeslots { get; set; } = new List<Timeslot>();
        public List<Calendar> Calendars { get; set; } = new List<Calendar>();
        public List<Booking> Bookings { get; set; } = new List<Booking>();
        public User User { get; set; } = new();

        public Teacher()
        {
            
        }

        public Teacher(string firstName, string lastName, User user)
        {
            Validate();
            FirstName = firstName;
            LastName = lastName;
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