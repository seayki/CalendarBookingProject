using CalendarBooking.ApplicationLayer.Queries;
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
    public class TeacherQueryService : ITeacherQueryService
    {

        private readonly DBContext _dbcontext;

        public TeacherQueryService(DBContext dBContext)
        {

            _dbcontext = dBContext;
        }

        public async Task<int> CountAsync()
        {
            return await _dbcontext.Teachers.CountAsync();
        }

        public async Task<IEnumerable<Teacher>> GetAllAsync()
        {
            return await _dbcontext.Teachers.ToListAsync();
        }

        public async Task<Teacher?> GetByIdAsync(int id)
        {
            return await _dbcontext.Teachers.FindAsync(id);
        }
    }
}
