

using System.ComponentModel.DataAnnotations;

namespace CalendarBooking.DomainLayer.Entities
{
    public class Booking
    {
        [Key]
        public int Id { get; set; }

        public DateTime Time { get; set; }
        [Required]
        public DateTime TimeStart { get; set; }
        [Required]
        public DateTime TimeStop{ get; set; }
        [Required]
        public Student Student { get; set; } = new Student();
     
        public Timeslot Timeslot { get; set; } = new Timeslot();
      
        public Teacher Teacher { get; set; } = new Teacher();
    }
}