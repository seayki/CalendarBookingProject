using CalendarBooking.DomainLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarBooking.ApplicationLayer.Queries
{
    public interface IStudentQueryService 
    {

        Task<IEnumerable<Student?>> Delete(int id);
        Task<IEnumerable<Student>> GetAll();
        Task<Student?> FindById(int Id);
        Task<Student?> UpdateName(int id, string name);
        Task<Student?> AddStudent(string firstName, string lastName);
       


    }
}
