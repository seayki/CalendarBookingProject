using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarBooking.App.Shared.Models
{
    public class Booking
    {
        public int Id { get; set; }

        public DateTime Time { get; set; }
        public DateTime TimeStart { get; set; }
        public DateTime TimeStop { get; set; }
      
    }
}
