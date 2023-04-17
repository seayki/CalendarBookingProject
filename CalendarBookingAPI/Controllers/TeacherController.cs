using CalendarBooking.ApplicationLayer.Commands;
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
        public async Task<ActionResult<List<Teacher>>> GetAllTeachers()
        {
            var result = await _teacherQueryService.GetAllAsync();
            if (result == null)
            {
                return BadRequest("Error Occurred");
            }
            return Ok(result);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Teacher>> GetById(int id)
        {
            var result = await _teacherQueryService.GetByIdAsync(id);
            if (result == null)
            {
                return BadRequest("Error Occurred");
            }
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult> Create(Teacher teacher)
        {
            try
            {
                await _teacherCommandService.Create(teacher);
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
                await _teacherCommandService.Delete(id);
                return Ok();
            }

            catch
            {
                return BadRequest();
            }
        }

        [HttpPut]
        public async Task<ActionResult> Update(Teacher teacher, int id)
        {
            try
            {
                await _teacherCommandService.Update(teacher, id);
                return Ok();
            }

            catch
            {
                return BadRequest();
            }
        }

    }
}
