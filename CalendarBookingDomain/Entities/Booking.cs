

using CalendarBooking.DomainLayer.DomainServices;
using System.ComponentModel.DataAnnotations;

namespace CalendarBooking.DomainLayer.Entities
{
    public class Booking
    {
        private readonly IBookingDomainService _bookingDomainService;

        [Key]
        public int Id { get; set; }

        public DateTime Time { get; set; }
        [Required]
        public DateTime TimeStart { get; set; }
        [Required]
        public DateTime TimeStop{ get; set; }
        [Required]
        public Student Student { get; set; } = new Student();
     
        public Timeslot Timeslot { get; set; } = new Timeslot();
      
        public Teacher Teacher { get; set; } = new Teacher();

        public Booking(IBookingDomainService bookingDomainService)
        {
            _bookingDomainService = bookingDomainService;
        }

        public bool IsBookingOverlapping(int id, Booking booking) {
            _bookingDomainService.IsBookingOverlapping(id, booking);
            return true;
        }
    }
}