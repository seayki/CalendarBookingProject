using CalendarBooking.ApplicationLayer.DTO;
using CalendarBooking.DomainLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarBooking.ApplicationLayer.Queries
{
    public interface ITeacherQueryService
    {
        Task<IEnumerable<TeacherDTO>> GetAllAsync();
        Task<Teacher?> GetByIdAsync(int id);
        Teacher? GetById(int id);
    }
}
