using CalendarBooking.DomainLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarBooking.ApplicationLayer.Commands
{
    public interface IGroupCommandService
    {
        Task Delete(int id);

        Task Update(Group entity, int id);

        Task Create(Group entity);
    }
}
