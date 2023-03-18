using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarBooking.DomainLayer.Entities
{
    public class EntitySuperclass
    {
        public int Id { get; set; }

        [Timestamp]
        public byte[] Version { get; set; }
    }
}
