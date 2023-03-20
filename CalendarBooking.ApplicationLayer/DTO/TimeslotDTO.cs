using CalendarBooking.DomainLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarBooking.ApplicationLayer.DTO
{
    public class TimeslotDTO
    {



        public int Id { get; set; }
        public DateTime SessionLength { get; set; }

        public DateTime TimeStart { get; set; }

        public DateTime TimeStop { get; set; }
        public CalendarDTO Calendar { get; set; } = new CalendarDTO();
        public List<BookingDTO> Bookings { get; set; } = new List<BookingDTO>();
        public TeacherDTO Teacher { get; set; } = new TeacherDTO();



    }
}
