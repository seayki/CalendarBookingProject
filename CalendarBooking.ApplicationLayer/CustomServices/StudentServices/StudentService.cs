using CalendarBooking.DomainLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace CalendarBooking.ApplicationLayer.CustomServices.StudentServices
{
    public class StudentService : IStudentService
    {


        //private readonly DbContext _dbcontext;

        //public StudentService(DbContext dbcontext)
        //{
        //    _dbcontext = dbcontext;
        //}
        public List<Student> GetByAlphabeticalOrder()
        {
            throw new NotImplementedException();
        }

        void ICustomService<Student>.Delete(Student entity)
        {
            throw new NotImplementedException();
        }

        void ICustomService<Student>.FindById(int Id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Student> ICustomService<Student>.GetAll()
        {
                throw new NotImplementedException();
        }

        void ICustomService<Student>.Insert(Student entity)
        {
            throw new NotImplementedException();
        }

        Task<Student> ICustomService<Student>.Update(Student entity)
        {
            throw new NotImplementedException();
        }

    }
}
