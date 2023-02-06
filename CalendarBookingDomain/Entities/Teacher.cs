namespace CalendarBooking.DomainLayer.Entities
{
    public class Teacher
    {
        public List<Timeslot> Timeslots { get; set; } = new List<Timeslot>();
        public List<Calendar> Calendars { get; set; } = new List<Calendar>();
        public List<Booking> Bookings { get; set; } = new List<Booking>();
    }
}