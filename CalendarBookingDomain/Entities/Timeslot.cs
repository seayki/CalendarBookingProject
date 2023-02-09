using System.ComponentModel.DataAnnotations;

namespace CalendarBooking.DomainLayer.Entities
{
    public class Timeslot
    {
        [Key]
        public int Id { get; set; }
        public DateTime SessionLength { get; set; }
        public DateTime TimeStart { get; set; }
        public DateTime TimeStop { get; set; }
        public Calendar Calendar { get; set; } = new Calendar();
        public List<Booking> Bookings { get; set; } = new List<Booking>();
        public Teacher Teacher { get; set; } = new Teacher(); 



    }
}