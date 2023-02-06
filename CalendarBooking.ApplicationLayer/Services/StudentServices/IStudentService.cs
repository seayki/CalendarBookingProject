

using CalendarBooking.DomainLayer.Entities;

namespace CalendarBooking.ApplicationLayer.Services.StudentServices
{
    public interface IStudentService
    {
        Task<List<Student>> GetAllStudents();

        Task<Student?> GetAStudent(int id);

        Task<List<Student>> AddStudent(Student Student);

        Task<Student?> UpdateStudent(int id, Student student_request);

        Task<List<Student>?> DeleteStudent(int id);



    }
}
