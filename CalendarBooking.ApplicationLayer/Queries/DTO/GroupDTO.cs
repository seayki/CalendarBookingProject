using CalendarBooking.DomainLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarBooking.ApplicationLayer.Queries.DTO {
    public class GroupDTO {
        public int Id { get; set; }

        public string? Name { get; set; }

        public int Count { get; set; }
        public List<StudentDTO> Students { get; set; } = new();
        public List<CalendarDTO> Calendars { get; set; } = new();
    }

}
