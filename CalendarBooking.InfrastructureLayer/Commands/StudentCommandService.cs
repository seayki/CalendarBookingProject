using CalendarBooking.ApplicationLayer.Commands;
using CalendarBooking.DomainLayer.Entities;
using CalendarBooking.InfrastructureLayer.Data;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace CalendarBooking.InfrastructureLayer.Commands
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


        public async Task UpdateName(int id, string name)
        {
            var student = await _dbcontext.Students.FindAsync(id);
            if (student != null)
            {
                student.FirstName = name;
                await _dbcontext.SaveChangesAsync();
            }



        }


        public async Task Insert(Student entity)
        {
            _dbcontext.Students.Add(entity);
            await _dbcontext.SaveChangesAsync();
        }


        public async Task Update(Student entity, int Id)
        {

            using var transaction = _dbcontext.Database.
            BeginTransaction(IsolationLevel.Serializable);
            try
            {
                var student = _dbcontext.Students.Find(Id);
                if (student != null)
                {

                    _dbcontext.Entry(student).State = EntityState.Modified;
                    student.FirstName = entity.FirstName;
                    student.LastName = entity.LastName;
                    student.Email = entity.Email;
                    _dbcontext.SaveChanges();
                    await transaction.CommitAsync();

                }
            }

            catch (DbUpdateConcurrencyException ex)
            {

                // Handle the exception by getting the entry that caused the conflict
                var entry = ex.Entries.Single();
                var clientValues = (Student)entry.Entity;
                var databaseValues = (Student)entry.GetDatabaseValues().ToObject();


                // Check if the row version values match, if not, throw an exception
                if (clientValues.Version != databaseValues.Version)
                {
                    transaction.Rollback();
                }
                else
                {
                    // Update the row version property with the new value from the database
                    clientValues.Version = databaseValues.Version;
                    // Retry the save operation
                    _dbcontext.SaveChanges();
                }

            }
        }
    }
}






