using CalendarBooking.DomainLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarBooking.ApplicationLayer.Queries
{
    public interface IStudentBookingQuery
    {
        StudentBookingQueryResultDTO GetBookings(int studentID);

    }

    public class StudentBookingQueryResultDTO
    {
        public StudentDTO Student { get; set; } = new StudentDTO();
    }

    public class BookingDTO
    {
        public int Id { get; set; }

        public DateTime Time { get; set; }

        public DateTime TimeStart { get; set; }

        public DateTime TimeStop { get; set; }

        public StudentDTO Student { get; set; } = new StudentDTO();

        public Timeslot Timeslot { get; set; } = new Timeslot();

        public Teacher Teacher { get; set; } = new Teacher();
    }

    public class StudentDTO
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public string? Email { get; set; }

        public List<BookingDTO> Bookings { get; set; } = new();

    }

}
