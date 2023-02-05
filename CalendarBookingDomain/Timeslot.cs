namespace CalendarBookingDomain
{
    public class Timeslot
    {
        public DateTime TimeStart { get; set; }
        public DateTime TimeStop { get; set; }
        public Calendar Calendar { get; set; } = new Calendar();
        public List<Booking> Bookings { get; set; } = new List<Booking>();
        public Teacher Teacher { get; set; } = new Teacher();


        public Timeslot()
        {

        }
    }
}