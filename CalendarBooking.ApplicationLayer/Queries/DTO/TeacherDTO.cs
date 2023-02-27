using CalendarBooking.DomainLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarBooking.ApplicationLayer.Queries.DTO {
    public class TeacherDTO {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public List<TimeslotDTO> Timeslots { get; set; } = new List<TimeslotDTO>();
        public List<CalendarDTO> Calendars { get; set; } = new List<CalendarDTO>();
        public List<BookingDTO> Bookings { get; set; } = new List<BookingDTO>();
    }
}
