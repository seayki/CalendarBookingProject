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
    public class StudentServices : IStudentService
    {
     
        private readonly DBContext _dbcontext;

        public StudentServices(DBContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<IEnumerable<Student?>> Delete(int Id)
        {
            var student = _dbcontext.Students.Find(Id);
            if (student != null)
            {
                _dbcontext.Students.Remove(student);
            }
            _dbcontext.SaveChanges();

            var students = await _dbcontext.Students.ToListAsync();
            return students;
        }

        public async Task<Student?> FindById(int Id)
        {
            var student = await _dbcontext.Students.FindAsync(Id);
            return student;


        }

        public async Task<IEnumerable<Student>> GetAll()
        {
            var students = await _dbcontext.Students.ToListAsync();
            
            return students;
        }

        public void Insert(Student entity)
        {
            _dbcontext.Students.Add(entity);
            _dbcontext.SaveChanges();
        }

        public async Task<Student?> UpdateName(int id, string name)
        {
            _dbcontext.Students.Update(_dbcontext.Students.Find(id));
            return student;
        }

        public List<Student> GetByAlphabeticalOrder()
        {
            throw new NotImplementedException();
        }

        
    }
}
