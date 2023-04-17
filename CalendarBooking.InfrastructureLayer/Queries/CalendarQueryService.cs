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
    public class CalendarQueryService : ICalendarQueryService
    {
        private readonly DBContext _dbcontext;

        public CalendarQueryService(DBContext dBContext)
        {

            _dbcontext = dBContext;
        }

        public async Task<int?> CountAsync()
        {
            return await _dbcontext.Calendars.CountAsync();
        }
        
        public async Task<IEnumerable<Calendar>> GetAllAsync()
        {
            return await _dbcontext.Calendars.ToListAsync();
        }

        public async Task<Calendar?> GetByIdAsync(int id)
        {
            return await _dbcontext.Calendars.FindAsync(id);
        }
    }
}
