

using CalendarBooking.ApplicationLayer.Commands;
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
        private readonly IStudentCommandService _studentCommandService;
        public StudentController(IStudentQueryService studentQueryService, IStudentCommandService studentCommandService)
        {
            _studentQueryService = studentQueryService;
            _studentCommandService = studentCommandService;
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
            var result = await _studentCommandService.Delete(id);
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
        public async Task<ActionResult<Student?>> Update(Student entity, int id)

        {
            await _studentCommandService.Update(entity, id);
         
            return Ok();
        }


        [HttpPost]
        public async Task<ActionResult<Student>> AddStudent(string firstName, string lastName)
        {
            var result = await _studentCommandService.AddStudent(firstName, lastName);
            if (result == null)
            {
                return NotFound("Error Occurred");
            }
            return Ok(result);
        }


      


    }


}
