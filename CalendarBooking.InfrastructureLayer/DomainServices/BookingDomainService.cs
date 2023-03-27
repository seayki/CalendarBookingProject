using CalendarBooking.DomainLayer.DomainServices;
using CalendarBooking.DomainLayer.Entities;
using CalendarBooking.InfrastructureLayer.Data;
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
           foreach (var Booking in booking.Student.Bookings) 
           {

                if (Booking.TimeEnd >= DateTime.Now) {
                    if (booking.TimeStart < Booking.TimeEnd && booking.TimeStart > Booking.TimeStart || booking.TimeEnd > Booking.TimeStart && booking.TimeEnd < Booking.TimeEnd) {
                        return true;
                    }
                }
           }
           return false;     
            
        }
        public bool IsBookingLimitReached(Booking booking)
        {
            int count = 0;
            foreach (var Booking in  booking.Student.Bookings) 
            { 
                if (Booking.TimeEnd >= DateTime.Now) 
                {
                    count++;
                }
            }
            if (count == 2)
            {
                return false;
            }
            return true;
        }

        public bool IsBookingNotWithinTimeslot(Booking booking) {
            if (booking.TimeStart >= booking.Timeslot.TimeStart && booking.TimeEnd <= booking.Timeslot.TimeEnd) {
                return true;
            }
            return false;
        }

        public bool IsBookingUnderMinTimespan(Booking booking) {
            if (booking.TimeEnd.Subtract(booking.TimeStart).TotalMinutes >= 30) {
                return true;
            }
            return false;
        }
    }
}
 