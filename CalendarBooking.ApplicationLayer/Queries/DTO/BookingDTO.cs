using CalendarBooking.DomainLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarBooking.ApplicationLayer.Queries.DTO {
    public class BookingDTO {
        public int Id { get; set; }

        public DateTime Time { get; set; }

        public DateTime TimeStart { get; set; }

        public DateTime TimeStop { get; set; }

        public StudentDTO Student { get; set; } = new StudentDTO();

        public TimeslotDTO Timeslot { get; set; } = new TimeslotDTO();

        public TeacherDTO Teacher { get; set; } = new TeacherDTO();
    }

}
