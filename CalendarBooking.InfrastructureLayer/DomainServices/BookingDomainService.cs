using CalendarBooking.DomainLayer.DomainServices;
using CalendarBooking.DomainLayer.Entities;
using CalendarBooking.InfrastructureLayer.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarBooking.InfrastructureLayer.DomainServices
{
    public class BookingDomainService : IBookingDomainService
    {
        private readonly DBContext _dbContext;

        public BookingDomainService(DBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public bool IsBookingOverlapping(Booking booking)
        {

            bool isOverlapping = _dbContext.Bookings
            .Any(b => /*b.Id != booking.Id &&*/ b.TimeStart < booking.TimeEnd && b.TimeEnd > booking.TimeStart && b.TimeStart > DateTime.Now);        
            return isOverlapping;     
            
        }
        public bool IsBookingLimitReached(Booking booking)
        {
            var studentId = booking.Student.Id;
            var hasTwoOrMoreFutureBookings = _dbContext.Bookings
                .Where(b => b.Student.Id == booking.Student.Id && b.TimeStart > DateTime.Today)
                .GroupBy(b => b.Student.Id)
                .Any(g => g.Count() >= 2);
            return hasTwoOrMoreFutureBookings;
        }

        public bool IsBookingNotWithinTimeslot(Booking booking) {
            if (booking.TimeStart >= booking.Timeslot.TimeStart && booking.TimeEnd <= booking.Timeslot.TimeEnd) {
                return false;
            }
            return true;
        }

        public bool IsBookingUnderMinTimespan(Booking booking) {
            if (booking.TimeEnd.Subtract(booking.TimeStart).TotalMinutes < 30) {
                return true;
            }
            return false;
        }
    }
}
 