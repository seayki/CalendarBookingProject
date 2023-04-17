using CalendarBooking.DomainLayer.DomainServices;
using CalendarBooking.DomainLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarBooking.ApplicationLayer.ReposatoryServices
{
    public interface ITimeslotRepo
    {
        void Delete(int id);

        void Update(Timeslot entity, int id);

        void Create(Timeslot entity);
    }
}
