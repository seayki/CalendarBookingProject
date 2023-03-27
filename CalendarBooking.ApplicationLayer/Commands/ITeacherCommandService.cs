using CalendarBooking.DomainLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarBooking.ApplicationLayer.Commands
{
    public interface ITeacherCommandService
    {
        Task Delete(int id);

        Task Update(Teacher entity, int id);

        Task Create(Teacher entity);
    }
}
