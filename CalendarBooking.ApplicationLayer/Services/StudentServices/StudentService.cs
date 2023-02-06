using CalendarBooking.DomainLayer.Entities;

namespace CalendarBooking.ApplicationLayer.Services.StudentServices
{
    public class StudentService : IStudentService
    {

        private readonly DBContext _dbcontext;
        public StudentService(DBContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<List<Student>> AddStudent(Student student)
        {
            _dbcontext.Students.Add(student);
            await _dbcontext.SaveChangesAsync();
            return _dbcontext.Students.ToList();
        }

        public async Task<List<Student>?> DeleteStudent(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Student>> GetAllStudents()
        {
            throw new NotImplementedException();
        }

        public async Task<Student?> GetAStudent(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Student?> UpdateStudent(int id, Student student_request)
        {
            throw new NotImplementedException();
        }
    }
}
