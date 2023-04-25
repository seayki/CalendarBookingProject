using CalendarBooking.ApplicationLayer.Commands;
using CalendarBooking.ApplicationLayer.ReposatoryServices;
using CalendarBooking.DomainLayer.DomainServices;
using CalendarBooking.DomainLayer.Entities;
using CalendarBooking.InfrastructureLayer.Data;
using CalendarBooking.InfrastructureLayer.DomainServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarBooking.InfrastructureLayer.Commands
{
    public class CalendarRepo : ICalendarRepo
    {

        private readonly DBContext _dbcontext;
        public CalendarRepo(DBContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public void Create(Calendar calendar)
        {                
            _dbcontext.Calendars.Add(calendar);      
        }

        public void Delete(int id) {
            var calendar = _dbcontext.Calendars.Find(id);
            if (calendar != null)
            {
                _dbcontext.Calendars.Remove(calendar);
            }
        }

        public void Update(string name, int id) {
            var calendar = _dbcontext.Calendars.Find(id);
            if (calendar != null)
            {
                calendar.Title = name;
            }

        }
    }
}
