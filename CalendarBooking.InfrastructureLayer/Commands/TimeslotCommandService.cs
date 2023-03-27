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
    public class TimeslotCommandService : ITimeslotCommandService
    {
        private readonly DBContext _dbcontext;
        private readonly ITimeslotDomainService _timeslotDomainService;

        public TimeslotCommandService(DBContext dbcontext, ITimeslotDomainService timeslotDomainService)
        {
            _dbcontext = dbcontext;
            _timeslotDomainService = timeslotDomainService;
        }

        public Task Create(Timeslot entity) {
            throw new NotImplementedException();
        }

        public Task Delete(int id) {
            throw new NotImplementedException();
        }

        public Task Update(Timeslot entity, int id) {
            throw new NotImplementedException();
        }
    }
}
