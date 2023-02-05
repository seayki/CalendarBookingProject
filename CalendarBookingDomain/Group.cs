namespace CalendarBookingDomain
{
    public class Group
    {
        public List<Student> Students { get; set; } = new List<Student>();
        public List<Calendar> Calendars { get; set; } = new List<Calendar>();
    }
}