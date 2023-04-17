using CalendarBooking.ApplicationLayer.Commands;
using CalendarBooking.ApplicationLayer.ReposatoryServices;
using CalendarBooking.DomainLayer.DomainServices;
using CalendarBooking.DomainLayer.Entities;
using CalendarBooking.InfrastructureLayer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarBooking.InfrastructureLayer.Commands
{
    public class TeacherRepo : ITeacherRepo
    {

        private readonly DBContext _dbcontext;

        public TeacherRepo(DBContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public void Create(Teacher entity)
        {
            var teacher = new Teacher(entity.FirstName, entity.LastName);
            if (teacher != null)
            {
                _dbcontext.Teachers.Add(teacher);
            }
        }

        public void Delete(int id)
        {
            var teacher = _dbcontext.Teachers.Find(id);
            if (teacher != null)
            {
                _dbcontext.Teachers.Remove(teacher);
            }
        }

        public void Update(Teacher entity, int id)
        {
            var teacher = _dbcontext.Teachers.Find(id);
            if (teacher != null)
            {
                teacher.FirstName = entity.FirstName;
                teacher.LastName = entity.LastName;
            }
        }
    }
}
