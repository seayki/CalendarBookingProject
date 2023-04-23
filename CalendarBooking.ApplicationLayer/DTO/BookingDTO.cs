using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarBooking.ApplicationLayer.DTO
{
    public class BookingDTO
    {
        public DateTime TimeStart { get; set; }
        public DateTime TimeEnd { get; set; }
    }
}
