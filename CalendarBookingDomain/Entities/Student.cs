using System.ComponentModel.DataAnnotations;

namespace CalendarBooking.DomainLayer.Entities
{
    public class Student : EntitySuperclass
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string? Email { get; set; }

        public List<Booking> Bookings { get; set; } = new();
        public List<Group> Groups { get; set; } = new List<Group>();

        public Student()
        {
            
        }

    }


    /// <remarks>
    /// A student can have a maximum of 2 active (non expired) bookings. 
    /// </remarks>
}