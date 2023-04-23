using CalendarBooking.ApplicationLayer.DTO;
using CalendarBooking.DomainLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarBooking.ApplicationLayer.Queries
{
    public interface ICalendarQueryService
    {
        Task<IEnumerable<CalendarDTO>> GetAllAsync();
        Task<Calendar?> GetByIdAsync(int id);

        Calendar? GetById(int id);

    }
}
