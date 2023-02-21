

using CalendarBooking.ApplicationLayer.Queries;
using CalendarBooking.DomainLayer.Entities;
using Microsoft.AspNetCore.Mvc;


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

     

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Student>>> DeleteStudent(int id)
        {
            var result = await _studentQueryService.Delete(id);
            if (result == null)
            {
                return BadRequest("Error Occurred");
            }
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Student>> FindById(int id)
        {
            var result = await _studentQueryService.FindById(id);
            if (result == null)
            {
                return BadRequest("Error Occurred");
            }
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Student>> UpdateName(int id, string name)
        {
            var result = await _studentQueryService.UpdateName(id, name);
            if (result == null)
            {
                return NotFound("Error Occurred");
            }
            return Ok(result);
        }


        [HttpPost]

        public async Task<ActionResult<Student>> AddStudent(string firstName, string lastName)
        {
            var result = await _studentQueryService.AddStudent(firstName, lastName);
            if (result == null)
            {
                return NotFound("Error Occurred");
            }
            return Ok(result);
        }


      
            


    }


}
