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

        Task<IEnumerable<Student?>> Delete(int id);

        Task Update(Student entity, int Id);

        Task Insert(Student entity);

        Task UpdateName(int id, string name);

        Task<Student?> AddStudent(string firstName, string lastName);

    }

}
