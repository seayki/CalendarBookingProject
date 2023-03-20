using CalendarBooking.ApplicationLayer.Queries;
using CalendarBooking.InfrastructureLayer.Data;
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
    }
}
