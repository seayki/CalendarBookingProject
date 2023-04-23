using CalendarBooking.ApplicationLayer.DTO;
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
        Task<IEnumerable<TimeslotDTO>> GetAllAsync();
        Task<Timeslot?> GetByIdAsync(int id);
        Timeslot? GetById(int id);
    }
}
