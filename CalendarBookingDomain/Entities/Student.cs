using System.ComponentModel.DataAnnotations;

namespace CalendarBooking.DomainLayer.Entities
{
    public class Student
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public string? FirstName { get; set; }

        [Required]
        public string? LastName { get; set; }

        public List<Booking> Bookings { get; set; } = new();
        public List<Group> Groups { get; set; } = new List<Group>();
        
    }


    /// <remarks>
    /// A student can have a maximum of 2 active (non expired) bookings. 
    /// </remarks>
}