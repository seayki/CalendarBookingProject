
using System.ComponentModel.DataAnnotations;

namespace CalendarBooking.DomainLayer.Entities
{
    public class Calendar
    {
        [Key]
        public int Id { get; set; }
        public Group Group { get; set; } = new Group();
        public List<Teacher> Teachers { get; set; } = new List<Teacher>();
        public List<Timeslot> Timeslots { get; set; } = new List<Timeslot>();
    }
}