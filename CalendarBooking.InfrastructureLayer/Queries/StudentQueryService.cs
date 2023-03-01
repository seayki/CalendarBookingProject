using CalendarBooking.ApplicationLayer.Queries;
using CalendarBooking.ApplicationLayer.Services.StudentServices;
using CalendarBooking.DomainLayer.Entities;
using CalendarBooking.InfrastructureLayer.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarBooking.InfrastructureLayer.Queries
{
    public class StudentQueryService : IStudentQueryService
    {
        private readonly DBContext _dbcontext;

        public StudentQueryService(DBContext dBContext)
        {
            
            _dbcontext = dBContext;
        }


        public  async Task<IEnumerable<Student>> GetAll()
        {
            var students = await _dbcontext.Students.ToListAsync();

            return students;
        }

        public async Task<Student?> FindById(int Id)
        {
            var student = await _dbcontext.Students.FindAsync(Id);
            return student;


        }


        public async Task<IEnumerable<Booking>> GetBookings(int studentID)
        {
            var studentBookings = await _dbcontext.Bookings.Where(b => b.Student.Id == studentID).ToListAsync();
            return studentBookings;
        }


    }
}
