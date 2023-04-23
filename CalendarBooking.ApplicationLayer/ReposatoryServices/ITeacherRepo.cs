using CalendarBooking.DomainLayer.DomainServices;
using CalendarBooking.DomainLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarBooking.ApplicationLayer.ReposatoryServices
{
    public interface ITeacherRepo
    {
        void Delete(int id);

        void UpdateFirstName(string firstName, int id);

        void UpdateLastName(string lastName, int id);

        void Create(Teacher teacher);
    }
}
