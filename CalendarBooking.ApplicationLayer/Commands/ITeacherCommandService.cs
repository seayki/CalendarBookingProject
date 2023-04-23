using CalendarBooking.ApplicationLayer.DTO;
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

        Task UpdateFirstName(string firstName, int id);
        Task UpdateLastName(string lastName, int id);
        Task Create(CreateTeacherDTO createTeacherDTO);
    }
}
