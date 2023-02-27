using CalendarBooking.ApplicationLayer.Queries.DTO;
using CalendarBooking.DomainLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarBooking.ApplicationLayer.Queries
{
    public interface IStudentBookingQuery
    {
        StudentBookingQueryResultDTO GetBookings(int studentID);

    }

    public class StudentBookingQueryResultDTO
    {
        public StudentDTO Student { get; set; } = new StudentDTO();
    }

    
    

}
