
using System.ComponentModel.DataAnnotations;


namespace CalendarBooking.DomainLayer.Entities
{
    public class Group : EntitySuperclass
    {
        [Required]
        public string Name { get; set; }
        
        public int Count { get; set; }
        public List<Student> Students { get; set; } = new ();
        public List<Calendar> Calendars { get; set; } = new();


        public Group()
        {
            
        }
    }
}
