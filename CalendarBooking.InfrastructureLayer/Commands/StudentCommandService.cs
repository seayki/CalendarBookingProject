using CalendarBooking.ApplicationLayer.Commands;
using CalendarBooking.ApplicationLayer.Services;
using CalendarBooking.ApplicationLayer.Services.StudentServices;
using CalendarBooking.DomainLayer.Entities;
using CalendarBooking.InfrastructureLayer.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarBooking.InfrastructureLayer.Services
{
    public class StudentCommandService : IStudentCommandService
    {
     
        private readonly DBContext _dbcontext;

        public StudentCommandService(DBContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<IEnumerable<Student?>> Delete(int Id)
        {
            var student = _dbcontext.Students.Find(Id);
            if (student != null)
            {
                _dbcontext.Students.Remove(student);
                await _dbcontext.SaveChangesAsync();
            }
            return _dbcontext.Students.ToList();
        }

  

  
        public async Task<Student?> AddStudent(string firstName, string lastName)
        {
            var student = new Student() { FirstName = firstName, LastName = lastName };
            _dbcontext.Students.Add(student);
            _dbcontext.SaveChanges();
            var result = await _dbcontext.Students.FindAsync(student.Id);
            if (result != null)
            {
                return result;
            }
            return null;
        }


        public async Task<Student?> UpdateName(int id, string name)
        {
            var student = await _dbcontext.Students.FindAsync(id);
            if (student == null)
            {
                return null;
            }
            student.FirstName = name;
            await _dbcontext.SaveChangesAsync();
            return _dbcontext.Students.Find(id);
           
        }

      

        public async Task Insert(Student entity)
        {
             _dbcontext.Students.Add(entity);
            await _dbcontext.SaveChangesAsync();
        }


        public async Task<Student?> Update(Student entity, int Id)

        {
            
            var student = await _dbcontext.Students.FindAsync(Id);
            if (student != null)
            {
                student.FirstName = entity.FirstName;
                student.LastName = entity.LastName;
                _dbcontext.SaveChanges();
                return student;
            }

            return null;
        }

      
    }
}
