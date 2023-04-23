using CalendarBooking.DomainLayer.DomainServices;
using CalendarBooking.DomainLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarBooking.ApplicationLayer.ReposatoryServices
{
    public interface IStudentRepo
    {
        void Delete(int id);

        void Create(Student student);

        void UpdateEmail(string email, int id);
        void UpdateFirstName(string firstName, int id);
        void UpdateLastName(string lastName, int id);
    }
}
