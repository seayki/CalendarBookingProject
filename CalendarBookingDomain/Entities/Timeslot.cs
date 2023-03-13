using CalendarBooking.DomainLayer.DomainServices;
using System.ComponentModel.DataAnnotations;

namespace CalendarBooking.DomainLayer.Entities
{
    public class Timeslot : EntitySuperclass
    {
        private readonly _timeslotDomainService
        public DateTime TimeSlotLength { get; set; }
        [Required]
        public DateTime TimeStart { get; set; }
        [Required]
        public DateTime TimeStop { get; set; }
        [Required]
        public Calendar Calendar { get; set; } = new Calendar();
        public List<Booking> Bookings { get; set; } = new List<Booking>();
        [Required]
        public Teacher Teacher { get; set; } = new Teacher();

        public Timeslot(ITimeslotDomainService timeslotDomainService)
        {
            
        }


        public Timeslot()
        {
            public bool IsTimeslotOverlapping(Booking booking) {
                return _timeslotDomainService.IsTimeslotOverlapping(this.Id, booking);
            }
        }

    }
}