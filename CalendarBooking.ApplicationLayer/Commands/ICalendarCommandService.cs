using CalendarBooking.DomainLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarBooking.ApplicationLayer.Commands
{
    public interface ICalendarCommandService
    {
        Task Delete(int id);

        Task Update(string name, int id);

        Task Create(string name);
    }
}
