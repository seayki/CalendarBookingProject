using CalendarBooking.DomainLayer.DomainServices;

namespace CalendarBooking.DomainLayer.Entities
{
    public class Booking
    {

        private readonly IBookingService _bookingService;
        public DateTime TimeStart { get; set; }
        public DateTime TimeStop{ get; set; }
        public Student Student { get; set; } = new Student();
        public Timeslot Timeslot { get; set; } = new Timeslot();
        public Teacher Teacher { get; set; } = new Teacher();

        public Booking(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        
        DateTime? ReturnDateTimeNow()
        {
           return _bookingService.GetCurrentDateTime();
        }



    }

    
   

    //public Booking? CreateBooking(Student student)
    //{
    //    if (student.Bookings.Count >= 2)
    //    {
    //        return null;
    //    }
    //    var booking = new Booking()
    //    {
            
    //    };
    //    return booking;


    //}
}