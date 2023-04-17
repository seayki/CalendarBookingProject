using CalendarBooking.DomainLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarBooking.ApplicationLayer.Queries
{
    public interface ITimeslotQueryService
    {
        Task<IEnumerable<Timeslot>> GetAllAsync();
        Task<Timeslot?> GetByIdAsync(int id);
        Task<int> CountAsync();
    }
}
