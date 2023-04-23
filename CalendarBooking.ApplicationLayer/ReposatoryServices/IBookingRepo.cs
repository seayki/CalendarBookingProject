using CalendarBooking.DomainLayer.DomainServices;
using CalendarBooking.DomainLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarBooking.ApplicationLayer.ReposatoryServices
{
    public interface IBookingRepo
    {
        void Delete(int id);

        Booking UpdateTimeStart(DateTime timeStart, int id);

        void Create(Booking entity);
    }
}
