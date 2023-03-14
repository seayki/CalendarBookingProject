

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

        public Booking(IBookingDomainService bookingDomainService,DateTime timeStart, DateTime timeEnd, Student student)
        {
            _bookingDomainService = bookingDomainService;
            TimeStart = timeStart;
            TimeEnd = timeEnd;
            Student = student;
            ValidateBooking();
        }
        private void ValidateBooking()
        {
            ValidateIsSetAndInFuture(nameof(TimeStart), TimeStart);
            ValidateIsSetAndInFuture(nameof(TimeEnd), TimeEnd);
            if (_bookingDomainService.CheckBookingCount(this))
            {
                throw new Exception("Max bookings of two");
            }
            if (_bookingDomainService.IsBookingOverlapping(this))
            {
                throw new Exception("Booking is overlapping exsisting bookings");
            }


        }
        private void ValidateIsSetAndInFuture(string parameter, DateTime date)
        {
            if (date == default) throw new ArgumentException($"{parameter} is not set");
            if (date <= DateTime.Now) throw new ArgumentException($"{parameter} must be in the future");
        }
    }
}
