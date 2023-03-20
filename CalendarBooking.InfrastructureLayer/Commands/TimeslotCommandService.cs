using CalendarBooking.ApplicationLayer.Commands;
using CalendarBooking.InfrastructureLayer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarBooking.InfrastructureLayer.Commands
{
    public class TimeslotCommandService : ITimeslotCommandService
    {
        private readonly DBContext _dbcontext;

        public TimeslotCommandService(DBContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
    }
}
