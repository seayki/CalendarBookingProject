using CalendarBookingDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarBooking.Domain.BookingService
{
    public class BookingInterface : IBookingService
    {
        public Booking AddBooking(Student student, DateTime start, DateTime end)
        {
            Booking booking = new Booking(start, end) { Student = student, };

            student.Bookings.Add(booking);

            return booking;
        }

        public List<Booking> GetAll(Student student)
        {
            throw new NotImplementedException();
        }
    }
}
