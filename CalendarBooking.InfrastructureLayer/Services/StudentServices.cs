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
        public void Delete(Student entity)
        {
            _dbcontext.Students.Remove(entity);
            _dbcontext.SaveChanges();
        }

        public void FindById(int Id)
        {
            _dbcontext.Students.Where(a => a.Id == Id);
        }

        public async Task<IEnumerable<Student>> GetAll()
        {
            var result = await _dbcontext.Students.ToListAsync();
            return result;
        }

        public void Insert(Student entity)
        {
            _dbcontext.Students.Add(entity);
            _dbcontext.SaveChanges();
        }

        public async Task<Student> Update(Student entity)
        {
            Student student = entity;
            await Task.CompletedTask;
            return student;
        }

        public List<Student> GetByAlphabeticalOrder()
        {
            throw new NotImplementedException();
        }
    }
}
