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
    
      
        Task<IEnumerable<Student>> GetAll();
        Task<Student?> FindById(int Id);

        




    }

    
}
