using CalendarBooking.DomainLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarBooking.DomainLayer.DomainServices {
    public interface ITimeslotDomainService {
        public bool IsTimeslotOverlapping(int id, Timeslot timeslot);
    }
}
