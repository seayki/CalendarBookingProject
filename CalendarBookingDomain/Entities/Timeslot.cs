using CalendarBooking.DomainLayer.DomainServices;
using System.ComponentModel.DataAnnotations;

namespace CalendarBooking.DomainLayer.Entities
{
    public class Timeslot : EntitySuperclass
    {
        private readonly ITimeslotDomainService _timeslotDomainService;
        public DateTime TimeSlotLength { get; set; }
        [Required]
        public DateTime TimeStart { get; set; }
        [Required]
        public DateTime TimeEnd { get; set; }
        [Required]
        public Calendar Calendar { get; set; } = new Calendar();
        public List<Booking> Bookings { get; set; } = new List<Booking>();
        [Required]
        public Teacher Teacher { get; set; } = new Teacher();

        public Timeslot(ITimeslotDomainService timeslotDomainService, DateTime timeStart, DateTime timeEnd, Teacher teacher)
        {
            _timeslotDomainService = timeslotDomainService;
            TimeStart = timeStart;
            TimeEnd = timeEnd;
            Teacher = teacher;
            ValidateTimeslot();
        }


        public Timeslot()
        {
          
        }

        private void ValidateTimeslot()
        {
            
            if (_timeslotDomainService.IsTimeslotOverlapping(Teacher.Id, this))
            {
                throw new Exception("Booking is overlapping exsisting bookings");
            }
        }

      

    }
}