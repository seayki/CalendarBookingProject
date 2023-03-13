

using CalendarBooking.DomainLayer.DomainServices;
using System.ComponentModel.DataAnnotations;

namespace CalendarBooking.DomainLayer.Entities
{
    public class Booking : EntitySuperclass
    {
        private readonly IBookingDomainService _bookingDomainService;
        [Required]
        public DateTime Time { get; set; }
        [Required]
        public DateTime TimeStart { get; set; }
        [Required]
        public DateTime TimeEnd{ get; set; }
        [Required]
        public Student Student { get; set; } = new Student();
        [Required]
        public Timeslot Timeslot { get; set; } = new Timeslot();
        [Required]
        public Teacher Teacher { get; set; } = new Teacher();


        public Booking()
        {

        }

        public Booking(IBookingDomainService bookingDomainService)
        {
            _bookingDomainService = bookingDomainService;
        }

        public bool IsBookingOverlapping(Booking booking) {
            return _bookingDomainService.IsBookingOverlapping(this.Id, booking);
        }
    }
}
