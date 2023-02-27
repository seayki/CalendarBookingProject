using CalendarBooking.ApplicationLayer.Services;
using CalendarBooking.ApplicationLayer.Services.CalendarServices;
using CalendarBooking.DomainLayer.Entities;
using CalendarBooking.InfrastructureLayer.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarBooking.InfrastructureLayer.Services
{
    public class CalendarServices : ICalendarService
    {

        private readonly DBContext _dbcontext;

        public CalendarServices(DBContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public Task<IEnumerable<Calendar?>> Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Calendar?> FindById(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Calendar>> GetAll()
        {
            var calendars = await _dbcontext.Calendars.ToListAsync();

            return calendars;
        }

        public Task Insert(Calendar obj)
        {
            throw new NotImplementedException();
        }

        public Task<Calendar> Update(Calendar obj, int id)
        {
            throw new NotImplementedException();
        }

        
    }
}
