

using System.ComponentModel.DataAnnotations;

namespace CalendarBooking.DomainLayer.Entities
{
    public class Booking
    {
        [Key]
        public int Id { get; set; }

        public DateTime Time { get; set; }
        public DateTime TimeStart { get; set; } 
        public DateTime TimeStop{ get; set; }
        public Student Student { get; set; } = new Student();
        public Timeslot Timeslot { get; set; } = new Timeslot();
        public Teacher Teacher { get; set; } = new Teacher();
    }
}