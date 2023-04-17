
using System.ComponentModel.DataAnnotations;


namespace CalendarBooking.DomainLayer.Entities
{
    public class Group : EntitySuperclass
    {
        [Required]
        public string Name { get; set; }
        public List<Student> Students { get; set; } = new ();
        public List<Calendar> Calendars { get; set; } = new();


        public Group(string name)
        {
            Name = name;
        }

        public int GetCount()
        {
            return Students.Count;
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        public void AddCalendar(Calendar calendar) 
        { 
            Calendars.Add(calendar);
        }
    }
}
