using CalendarBooking.ApplicationLayer.Queries;
using CalendarBooking.ApplicationLayer.Services.CalendarServices;
using CalendarBooking.DomainLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarBooking.InfrastructureLayer.Queries
{
    public class CalendarQueryService : ICalendarQueryService
    {
      
        private readonly ICalendarService _calendarService;
        public CalendarQueryService(ICalendarService calendarService)
        {
            _calendarService = calendarService;
        }
        public Task<IEnumerable<Calendar>> GetAll()
        {
            return _calendarService.GetAll();
        }
    }
}

