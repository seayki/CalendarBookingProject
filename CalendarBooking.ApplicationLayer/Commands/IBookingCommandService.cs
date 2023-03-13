using CalendarBooking.DomainLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarBooking.ApplicationLayer.Commands
{
    public interface IBookingCommandService
    {
        Task<Booking?> Delete(int id);

        Task<Booking> Update(Booking entity, int Id);

        Task<Booking?> CreateBooking(DateTime timeStart, DateTime timeEnd, Student student, Teacher teacher, Timeslot timeSlot);

    }
}
