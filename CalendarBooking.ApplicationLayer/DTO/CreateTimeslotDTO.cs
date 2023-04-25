using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarBooking.ApplicationLayer.DTO
{
    public class CreateTimeslotDTO
    {
        public DateTime timeStart { get; set; }
        public DateTime timeEnd { get; set; }
        public int teacherId { get; set; }
        public int calendarId { get; set; }
    }
}
