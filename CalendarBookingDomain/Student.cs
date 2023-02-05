namespace CalendarBookingDomain
{
    public class Student
    {
        public List<Booking> Bookings { get; set; } = new();
        public List<Group> Groups { get; set; } = new List<Group>();
        
    }


    /// <remarks>
    /// A student can have a maximum of 2 active (non expired) bookings. 
    /// </remarks>
}