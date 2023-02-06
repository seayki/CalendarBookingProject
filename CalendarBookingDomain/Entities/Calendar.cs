
namespace CalendarBooking.DomainLayer.Entities
{
    public class Calendar
    {
        public Group Group { get; set; } = new Group();
        public List<Teacher> Teachers { get; set; } = new List<Teacher>();
        public List<Timeslot> Timeslots { get; set; } = new List<Timeslot>();
    }
}