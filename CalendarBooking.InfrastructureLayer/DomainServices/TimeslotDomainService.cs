using CalendarBooking.DomainLayer.DomainServices;
using CalendarBooking.DomainLayer.Entities;
using CalendarBooking.InfrastructureLayer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarBooking.InfrastructureLayer.DomainServices
{
    public class TimeslotDomainService: ITimeslotDomainService
    {
        private readonly DBContext _dBContext;

        public TimeslotDomainService(DBContext dBContext)
        {
            _dBContext = dBContext;
        }

        public bool IsTimeslotOverlapping(Timeslot timeslot)
        {
            foreach (Timeslot _timeslot in timeslot.Teacher.Timeslots) {
                if (timeslot.TimeStart >= _timeslot.TimeStart && timeslot.TimeStart <= _timeslot.TimeEnd || timeslot.TimeEnd <= _timeslot.TimeEnd && timeslot.TimeEnd >= _timeslot.TimeStart) 
                {
                    return true;
                }
            }
            return false;
        }
    }
}
