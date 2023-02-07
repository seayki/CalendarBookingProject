using System.ComponentModel.DataAnnotations;

namespace CalendarBooking.DomainLayer.Entities
{
    public class Teacher
    {
        [Key]
        public int Id { get; set; }
        public List<Timeslot> Timeslots { get; set; } = new List<Timeslot>();
        public List<Calendar> Calendars { get; set; } = new List<Calendar>();
        public List<Booking> Bookings { get; set; } = new List<Booking>();
    }
}