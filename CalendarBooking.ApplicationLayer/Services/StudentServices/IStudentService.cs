using CalendarBooking.DomainLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarBooking.ApplicationLayer.Services.StudentServices
{
    public interface IStudentService : ICustomService<Student>
    {
      
        Task<Student?> UpdateName(int id, string name);
        Task<Student?> AddStudent(string firstName, string lastName);
        

    }
}
