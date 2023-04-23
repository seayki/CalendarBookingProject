using CalendarBooking.ApplicationLayer.Commands;
using CalendarBooking.ApplicationLayer.DTO;
using CalendarBooking.ApplicationLayer.Queries;
using CalendarBooking.DomainLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CalendarBooking.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly ITeacherQueryService _teacherQueryService;
        private readonly ITeacherCommandService _teacherCommandService;

        public TeacherController(ITeacherQueryService teacherQueryService, ITeacherCommandService teacherCommandService)
        {
            _teacherQueryService = teacherQueryService;
            _teacherCommandService = teacherCommandService;
        }

        [HttpGet]
        public async Task<ActionResult<List<TeacherDTO>>> GetAllTeachers()
        {
            var result = await _teacherQueryService.GetAllAsync();
            if (result == null)
            {
                return NotFound("Error Occurred");
            }
            return Ok(result);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Teacher>> GetById(int id)
        {
            var result = await _teacherQueryService.GetByIdAsync(id);
            if (result == null)
            {
                return NotFound("Error Occurred");
            }
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult> Create(CreateTeacherDTO createTeacherDTO)
        {
            try
            {
                await _teacherCommandService.Create(createTeacherDTO);
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
                await _teacherCommandService.Delete(id);
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
                await _teacherCommandService.UpdateFirstName(firstName, id);
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
                await _teacherCommandService.UpdateLastName(lastName, id);
                return Ok();
            }

            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
