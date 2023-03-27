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
            ValidateIsSetAndInFuture(nameof(TimeStart), TimeStart);
            ValidateIsSetAndInFuture(nameof(TimeEnd), TimeEnd);
            if (_timeslotDomainService.IsTimeslotOverlapping(this))
            {
                throw new Exception("Timeslot overlaps with one or more existing timeslots.");
            }
        }

        private void ValidateIsSetAndInFuture(string parameter, DateTime date) {
            if (date == default) throw new ArgumentException($"{parameter} is not set");
            if (date <= DateTime.Now) throw new ArgumentException($"{parameter} must be in the future");
        }


    }
}