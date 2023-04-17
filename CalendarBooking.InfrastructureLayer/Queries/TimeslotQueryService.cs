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
    public class TimeslotQueryService : ITimeslotQueryService
    {
        private readonly DBContext _dbcontext;

        public TimeslotQueryService(DBContext dBContext)
        {

            _dbcontext = dBContext;
        }

        public async Task<int> CountAsync()
        {
            return await _dbcontext.Timeslots.CountAsync();
        }

        public async Task<IEnumerable<Timeslot>> GetAllAsync()
        {
            return await _dbcontext.Timeslots.ToListAsync();
        }

        public async Task<Timeslot?> GetByIdAsync(int id)
        {
            return await _dbcontext.Timeslots.FindAsync(id);
        }
    }
}
