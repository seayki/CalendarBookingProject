using CalendarBooking.DomainLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarBooking.ApplicationLayer.Commands
{
    public interface ITimeslotCommandService
    {
        Task Delete(int id);
        Task Create(DateTime timeStart, DateTime timeEnd, int teacherId, int calendarId);
    }
}
