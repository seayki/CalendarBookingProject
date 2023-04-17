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
            var result = await _studentQueryService.GetAllAsync();
            if (result == null)
            {
                return BadRequest("Error Occurred");
            }
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Student>> GetById(int id)
        {
            var result = await _studentQueryService.GetByIdAsync(id);
            if (result == null)
            {
                return BadRequest("Error Occurred");
            }
            return Ok(result);
        }
   

        [HttpPost]
        public async Task<ActionResult> Create(string firstName, string lastName)
        {
            try
            {
                await _studentCommandService.Create(firstName, lastName);
                return Ok();
            }
            catch
            {
                return BadRequest();
            }

        }
        [HttpDelete]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                await _studentCommandService.Delete(id);
                return Ok();
            }

            catch
            {
                return BadRequest();
            }
        }

        [HttpPut]
        public async Task<ActionResult> Update(Student student, int id)
        {
            try
            {
                await _studentCommandService.Update(student, id);
                return Ok();
            }

            catch
            {
                return BadRequest();
            }
        }
    }
}
