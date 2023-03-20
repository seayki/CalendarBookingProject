using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarBooking.ApplicationLayer.DTO
{
    public class CalendarDTO
    {

        public int Id { get; set; }
        public GroupDTO Group { get; set; } = new GroupDTO();
        public List<TeacherDTO> Teachers { get; set; } = new List<TeacherDTO>();
        public List<TimeslotDTO> Timeslots { get; set; } = new List<TimeslotDTO>();
    }
}
