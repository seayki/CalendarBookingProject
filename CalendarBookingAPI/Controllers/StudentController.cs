

using CalendarBooking.ApplicationLayer.Queries;
using CalendarBooking.ApplicationLayer.Services.StudentServices;
using CalendarBooking.DomainLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CalendarBooking.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]

    public class StudentController : ControllerBase
    {
        private readonly IStudentQueryService _studentQueryService;

        public StudentController(IStudentQueryService studentQueryService)
        {
            _studentQueryService = studentQueryService;
            
        }

        [HttpGet]
        public async Task<ActionResult<List<Student>>> GetAllStudents()
        {

            
            var result = await _studentQueryService.GetAll();
            if (result == null)
            {
                return BadRequest("Error Occurred");
            }
            return Ok(result);

        }


    }
       
}
