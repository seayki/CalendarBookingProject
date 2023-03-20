using CalendarBooking.ApplicationLayer.Commands;
using CalendarBooking.InfrastructureLayer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarBooking.InfrastructureLayer.Commands
{
    public class TeacherCommandService : ITeacherCommandService
    {
        private readonly DBContext _dbcontext;

        public TeacherCommandService(DBContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
    }
}
