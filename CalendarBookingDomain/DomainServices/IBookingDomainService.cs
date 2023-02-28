using CalendarBooking.DomainLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarBooking.DomainLayer.DomainServices
{
    public interface IBookingDomainService
    {
        public bool IsBookingOverlapping(int id, Booking booking);
    }
}
