using CalendarBooking.ApplicationLayer.DTO;
using CalendarBooking.DomainLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarBooking.ApplicationLayer.Queries
{
    public interface IStudentQueryService 
    {
    
        Task<IEnumerable<StudentDTO>> GetAllAsync();
        Task<Student?> GetByIdAsync(int id);
        Student? GetById(int id);
    }


}
