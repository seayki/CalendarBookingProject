using AutoMapper;
using CalendarBooking.ApplicationLayer.Queries;
using CalendarBooking.ApplicationLayer.Queries.DTO;
using CalendarBooking.DomainLayer.Entities;
using CalendarBooking.InfrastructureLayer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarBooking.InfrastructureLayer.Queries
{
    public class StudentBookingQuery : IStudentBookingQueryService
    {


        readonly DBContext _dbContext;
        private readonly IMapper _mapper;

        public StudentBookingQuery(DBContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        StudentBookingQueryResultDTO IStudentBookingQueryService.GetBookings(int studentID)
        {
            var dbResult = _dbContext.Bookings.Where(b => b.Student.Id == studentID).ToList();
            if (dbResult is null)
            {
                return new StudentBookingQueryResultDTO();
            }
            var studentDto = _mapper.Map<StudentDTO>(dbResult);
            return new StudentBookingQueryResultDTO { Student = studentDto };

        }

    }
}
