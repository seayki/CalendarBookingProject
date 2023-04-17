using CalendarBooking.ApplicationLayer.Commands;
using CalendarBooking.ApplicationLayer.ReposatoryServices;
using CalendarBooking.DomainLayer.DomainServices;
using CalendarBooking.DomainLayer.Entities;
using CalendarBooking.InfrastructureLayer.Data;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace CalendarBooking.InfrastructureLayer.Commands
{
    public class StudentRepo : IStudentRepo
    {

        private readonly DBContext _dbcontext;
        

        public StudentRepo(DBContext dbcontext)
        {
            _dbcontext = dbcontext;
        
        }



        public void Create(string firstName, string lastName)
        {
            var student = new Student(firstName, lastName);
            if (student != null)
            {
                _dbcontext.Students.Add(student);
            }
        }
        public void Delete(int Id)
        {
            var student = _dbcontext.Students.Find(Id);
            if (student != null)
            {
                _dbcontext.Students.Remove(student);
               
            }
           
        }

        public void Update(Student entity, int Id)
        {
            var student = _dbcontext.Students.Find(Id);

            if (student != null)
            {
                student.FirstName = entity.FirstName;
                student.LastName = entity.LastName;
            }
        }
        
    }
}






