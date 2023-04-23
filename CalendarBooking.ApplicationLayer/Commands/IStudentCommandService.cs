using CalendarBooking.ApplicationLayer.DTO;
using CalendarBooking.DomainLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarBooking.ApplicationLayer.Commands
{
    public interface IStudentCommandService
    {
        Task Create(CreateStudentDTO createStudentDTO);
        Task Delete(int id);

        Task UpdateEmail(string email, int Id);

        Task UpdateFirstName(string firstName, int Id);

        Task UpdateLastName(string lastName, int Id);
      


    }

}
