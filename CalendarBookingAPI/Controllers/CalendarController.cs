using CalendarBooking.ApplicationLayer.Commands;
using CalendarBooking.ApplicationLayer.Queries;
using CalendarBooking.DomainLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CalendarBooking.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalendarController : ControllerBase
    {
        private readonly ICalendarQueryService _calendarQueryService;
        private readonly ICalendarCommandService _calendarCommandService;

        public CalendarController(ICalendarQueryService calendarQueryService, ICalendarCommandService calendarCommandService)
        {
            _calendarQueryService = calendarQueryService;
            _calendarCommandService = calendarCommandService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Calendar>>> GetAllCalendars()
        {
            var result = await _calendarQueryService.GetAllAsync();
            if (result == null)
            {
                return BadRequest("Error Occurred");
            }
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Calendar>> GetById(int id)
        {
            var result = await _calendarQueryService.GetByIdAsync(id);
            if (result == null)
            {
                return BadRequest("Error Occurred");
            }
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult> Create(string calendarName)
        {
            try
            {
                await _calendarCommandService.Create(calendarName);
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
                await _calendarCommandService.Delete(id);
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPut]
        public async Task<ActionResult> Update(string calendarName, int id)
        {
            try
            {
                await _calendarCommandService.Update(calendarName, id);
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
