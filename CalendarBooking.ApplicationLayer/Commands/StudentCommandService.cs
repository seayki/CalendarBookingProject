using CalendarBooking.ApplicationLayer.Services.StudentServices;
using CalendarBooking.DomainLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarBooking.ApplicationLayer.Commands
{
    public class StudentCommandService : IStudentCommandService
    {

        private readonly IStudentService _studentService;
        public StudentCommandService(IStudentService studentService)
        {
            _studentService = studentService;
        }

        public Task<IEnumerable<Student?>> Delete(int id)
        {
            return _studentService.Delete(id);
        }

        public void Insert(Student entity)
        {
           _studentService.Insert(entity);
        }

        public Task<Student> Update(Student entity, int Id)
        {
           return _studentService.Update(entity, Id);
        }
    }
}
