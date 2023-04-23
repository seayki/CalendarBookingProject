using CalendarBooking.ApplicationLayer.DTO;
using CalendarBooking.DomainLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarBooking.ApplicationLayer.Queries
{
    public interface IGroupQueryService
    {
        Task<IEnumerable<GroupDTO>> GetAllAsync();
        Task<Group?> GetByIdAsync(int id);
    }
}
