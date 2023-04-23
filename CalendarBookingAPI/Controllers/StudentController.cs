using CalendarBooking.ApplicationLayer.Commands;
using CalendarBooking.ApplicationLayer.DTO;
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
        public async Task<ActionResult<List<StudentDTO>>> GetAllStudents()
        {
            var result = await _studentQueryService.GetAllAsync();
            if (result == null)
            {
                return NotFound("Error Occurred");
            }
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Student>> GetById(int id)
        {
            var result = await _studentQueryService.GetByIdAsync(id);
            if (result == null)
            {
                return NotFound("Error Occurred");
            }
            return Ok(result);
        }


        [HttpPost]
        public async Task<ActionResult> Create(CreateStudentDTO createStudentDTO)
        {
            try
            {
                await _studentCommandService.Create(createStudentDTO);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
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
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("UpdateEmail{email}")]
        public async Task<ActionResult> UpdateEmail(string email, int id)
        {
            try
            {
                await _studentCommandService.UpdateEmail(email, id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("UpdateFirstName{firstName}")]
        public async Task<ActionResult> UpdateFirstName(string firstName, int id)
        {
            try
            {
                await _studentCommandService.UpdateFirstName(firstName, id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpPut("UpdateLastName{lastName}")]
        public async Task<ActionResult> UpdateLastName(string lastName, int id)
        {
            try
            {
                await _studentCommandService.UpdateLastName(lastName, id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


    }
}
