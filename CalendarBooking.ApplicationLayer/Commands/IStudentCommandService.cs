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

        Task<Student> Update(Student entity, int Id);

        void Insert(Student entity);

        Task<Student?> UpdateName(int id, string name);

        Task<Student?> AddStudent(string firstName, string lastName);

    }

}
