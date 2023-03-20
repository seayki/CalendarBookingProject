using CalendarBooking.ApplicationLayer.Queries;
using CalendarBooking.InfrastructureLayer.Data;
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
    }
}
