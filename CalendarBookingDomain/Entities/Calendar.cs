
using System.ComponentModel.DataAnnotations;

namespace CalendarBooking.DomainLayer.Entities
{
    public class Calendar : EntitySuperclass
    {
        [Required]
        public string Title { get; set; } = string.Empty;
        public List<Group> Group { get; set; } = new List<Group>();
        public List<Teacher> Teachers { get; set; } = new List<Teacher>();
        public List<Timeslot> Timeslots { get; set; } = new List<Timeslot>();

        public Calendar()
        {
            
        }

        public Calendar(string title)
        {
            Title = title;
        }

     
    }

   
}