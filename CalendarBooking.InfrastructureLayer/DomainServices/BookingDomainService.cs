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

            if (booking.Student.Bookings.Count >= 2)
            {
                return false;
            }
            
           foreach (var Booking in booking.Student.Bookings) 
           {
                if (booking.TimeStart < Booking.TimeEnd && booking.TimeStart > Booking.TimeStart || booking.TimeEnd > Booking.TimeStart && booking.TimeEnd < Booking.TimeEnd)
                {

                    return true;
                }
           }
           return false;
            


            
        }

        public bool CheckBookingCount(Booking booking)
        {
            if (booking.Student.Bookings.Count >= 2)
            {
                return false;
            }
        }

        
    }
}
