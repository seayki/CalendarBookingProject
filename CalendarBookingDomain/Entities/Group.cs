using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarBooking.DomainLayer.Entities
{
    public class Group
    {
        public List<Student> Students { get; set; } = new ();
        public List<Calendar> Calendars { get; set; } = new();
    }
}
