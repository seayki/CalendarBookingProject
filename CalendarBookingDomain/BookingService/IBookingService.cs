using CalendarBookingDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarBooking.Domain.BookingService
{
    public interface IBookingService
    {
        Booking AddBooking(Student student, DateTime start, DateTime end);


        List<Booking> GetAll(Student student);
    }
}
