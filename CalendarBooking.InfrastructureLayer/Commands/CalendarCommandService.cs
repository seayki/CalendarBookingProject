using CalendarBooking.ApplicationLayer.Commands;
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

        public CalendarCommandService(DBContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
    }
}
