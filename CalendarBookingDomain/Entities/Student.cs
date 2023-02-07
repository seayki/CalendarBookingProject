namespace CalendarBooking.DomainLayer.Entities
{
    public class Student
    {
        public string Name = string.Empty;
        public int Id { get; set; }
        public List<Booking> Bookings { get; set; } = new();
        public List<Group> Groups { get; set; } = new List<Group>();
        
    }


    /// <remarks>
    /// A student can have a maximum of 2 active (non expired) bookings. 
    /// </remarks>
}