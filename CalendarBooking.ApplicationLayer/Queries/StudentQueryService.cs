using CalendarBooking.ApplicationLayer.Services.StudentServices;
using CalendarBooking.DomainLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarBooking.ApplicationLayer.Queries
{
    public class StudentQueryService : IStudentQueryService
    {

        private readonly IStudentService _studentService;
        public StudentQueryService(IStudentService studentService)
        {
            _studentService = studentService;
        }


        public Task<IEnumerable<Student>>GetAll()
        {
            return _studentService.GetAll();
        }



        public Task<Student?> FindById(int id)
        {
            return _studentService.FindById(id);
        }

        public Task<Student?> UpdateName(int id, string name)
        {
            return _studentService.UpdateName(id, name);
        }


        public Task<Student?> AddStudent(string firstName, string lastName)
        {
            return _studentService.AddStudent(firstName, lastName);
        }

     


    }
}
