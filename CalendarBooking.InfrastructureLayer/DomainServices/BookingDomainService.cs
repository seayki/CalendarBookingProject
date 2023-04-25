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
            bool isOverlapping = _dbContext.Bookings.Where(a => a.Timeslot.Id == booking.Timeslot.Id)
            .Any(a =>  a.TimeStart < booking.TimeEnd && a.TimeEnd > booking.TimeStart && a.TimeStart > DateTime.Now);        
            return isOverlapping;     
            
        }
        public bool IsBookingLimitReached(Booking booking)
        {
            var studentId = booking.Student.Id;
            var hasTwoOrMoreFutureBookings = _dbContext.Bookings
                .Where(a => a.Student.Id == booking.Student.Id && a.TimeStart > DateTime.Today)
                .GroupBy(a => a.Student.Id)
                .Any(a => a.Count() >= 2);
            return hasTwoOrMoreFutureBookings;
        }   
    }
}
 