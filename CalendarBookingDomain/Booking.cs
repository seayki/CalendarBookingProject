namespace CalendarBookingDomain
{
    public class Booking
    {
        public DateTime TimeStart { get; set; }
        public DateTime TimeStop{ get; set; }
        public Student Student { get; set; } = new Student();
        public Timeslot Timeslot { get; set; } = new Timeslot();
        public Teacher Teacher { get; set; } = new Teacher();

        public Booking(DateTime TimeStart, DateTime TimeStop)
        {


        }

        public void AddBooking()
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