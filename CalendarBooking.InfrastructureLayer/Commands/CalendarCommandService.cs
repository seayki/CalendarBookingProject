using CalendarBooking.ApplicationLayer.Commands;
using CalendarBooking.DomainLayer.DomainServices;
using CalendarBooking.DomainLayer.Entities;
using CalendarBooking.InfrastructureLayer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarBooking.InfrastructureLayer.Commands
{
    public class CalendarCommandService : ICalendarCommandService
    {

        private readonly DBContext _dbcontext;
        private readonly ICalendarDomainService _calendarDomainService;

        public CalendarCommandService(DBContext dbcontext, ICalendarDomainService calendarDomainService)
        {
            _dbcontext = dbcontext;
            _calendarDomainService = calendarDomainService;
        }

        public Task Create(Calendar entity) {
            throw new NotImplementedException();
        }

        public Task Delete(int id) {
            throw new NotImplementedException();
        }

        public Task Update(Calendar entity, int id) {
            throw new NotImplementedException();
        }
    }
}
