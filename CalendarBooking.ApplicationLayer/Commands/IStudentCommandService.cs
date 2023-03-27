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

        Task Delete(int id);

        Task Update(Student entity, int Id);

        Task Create(Student entity);

        Task UpdateName(int id, string name);

        Task AddStudent(string firstName, string lastName);

    }

}
