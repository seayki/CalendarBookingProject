using CalendarBooking.ApplicationLayer.Commands;
using CalendarBooking.ApplicationLayer.ReposatoryServices;
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
    public class TimeslotRepo : ITimeslotRepo
    {
        private readonly DBContext _dbcontext;
        private readonly ITimeslotDomainService _timeslotDomainService;

        public TimeslotRepo(DBContext dbcontext, ITimeslotDomainService timeslotDomainService)
        {
            _dbcontext = dbcontext;
            _timeslotDomainService = timeslotDomainService;
        }

        public void Create(Timeslot entity)
        {
            _dbcontext.Timeslots.Add(entity);
        }
        public void Delete(int Id)
        {
            var timeslot = _dbcontext.Timeslots.Find(Id);
            if (timeslot != null)
            {
                _dbcontext.Timeslots.Remove(timeslot);

            }

        }

        public void Update(Timeslot entity, int Id)
        {
            var timeslot = _dbcontext.Timeslots.Find(Id);

            if (timeslot != null)
            {
                timeslot.TimeStart = entity.TimeStart;
                timeslot.TimeEnd = entity.TimeEnd;
            }
        }
    }
}
