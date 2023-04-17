using CalendarBooking.ApplicationLayer.Queries;
using CalendarBooking.ApplicationLayer.UnitOfWork;
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

        public async Task<int> CountAsync()
        {
            return await _dbcontext.Students.CountAsync();
        }

        public async Task<IEnumerable<Student>> GetAllAsync()
        {
            return await _dbcontext.Students.ToListAsync();
        }

        public async Task<Student?> GetByIdAsync(int id)
        {
            return await _dbcontext.Students.FindAsync(id);
        }
    }
}
