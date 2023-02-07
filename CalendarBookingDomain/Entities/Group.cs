
using System.ComponentModel.DataAnnotations;


namespace CalendarBooking.DomainLayer.Entities
{
    public class Group
    {
        [Key]
        public int Id { get; set; }

        public string Name = string.Empty;
        public List<Student> Students { get; set; } = new ();
        public List<Calendar> Calendars { get; set; } = new();
    }
}
