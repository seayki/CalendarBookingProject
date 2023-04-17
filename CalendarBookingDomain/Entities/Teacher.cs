using System.ComponentModel.DataAnnotations;

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

        public Teacher()
        {
            
        }

        public Teacher(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;      
        }
    }
}