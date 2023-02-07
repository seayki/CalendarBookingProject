

using CalendarBooking.ApplicationLayer.CustomServices.StudentServices;
using CalendarBooking.DomainLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CalendarBooking.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]

    public class StudentController : ControllerBase
    {
        
        private readonly IStudentService _studentService;
        
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Student>>> GetAllStudents()
        {
            return await _studentService.GetAll();
        }




    }
}
