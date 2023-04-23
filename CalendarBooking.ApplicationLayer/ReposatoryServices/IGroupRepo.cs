using CalendarBooking.DomainLayer.DomainServices;
using CalendarBooking.DomainLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarBooking.ApplicationLayer.ReposatoryServices
{
    public interface IGroupRepo
    {
        void Delete(int id);

        void Update(string name, int id);

        void Create(string name);
    }
}
