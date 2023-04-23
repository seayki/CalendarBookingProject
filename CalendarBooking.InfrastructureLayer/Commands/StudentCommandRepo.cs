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

        public void Create(Student student)
        {
            _dbcontext.Students.Add(student);
        }
        public void Delete(int Id)
        {
            var student = _dbcontext.Students.Find(Id);
            if (student != null)
            {
                _dbcontext.Students.Remove(student);
            }
        }

        public void UpdateEmail(string email, int Id)
        {
            var student = _dbcontext.Students.Find(Id);

            if (student != null)
            {
                student.Email = email;
            }
        }

        public void UpdateFirstName(string firstName, int Id)
        {
            var student = _dbcontext.Students.Find(Id);

            if (student != null)
            {
                student.FirstName = firstName;  
            }
        }

        public void UpdateLastName(string lastName, int Id)
        {
            var student = _dbcontext.Students.Find(Id);

            if (student != null)
            {
                student.LastName = lastName;
            }
        }



    }
}






