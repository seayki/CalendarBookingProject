using CalendarBooking.DomainLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarBooking.ApplicationLayer.DTO
{
    public class CreateBookingDTO
    {
        public DateTime TimeStart { get; set; }   
        public DateTime TimeEnd { get; set; }     
        public int studentID { get; set; }
        public int timeslotID { get; set; }

    }
}
