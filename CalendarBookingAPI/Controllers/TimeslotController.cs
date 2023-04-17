using CalendarBooking.ApplicationLayer.Commands;
using CalendarBooking.ApplicationLayer.Queries;
using CalendarBooking.DomainLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CalendarBooking.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimeslotController : ControllerBase
    {

        private readonly ITimeslotQueryService _timeslotQueryService;
        private readonly ITimeslotCommandService _timeslotCommandService;

        public TimeslotController(ITimeslotQueryService timeslotQueryService, ITimeslotCommandService timeslotCommandService)
        {
            _timeslotQueryService = timeslotQueryService;
            _timeslotCommandService = timeslotCommandService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Timeslot>>> GetAll()
        {
            var result = await _timeslotQueryService.GetAllAsync();
            if (result == null)
            {
                return BadRequest("Error Occurred");
            }
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Timeslot>> GetById(int id)
        {
            var result = await _timeslotQueryService.GetByIdAsync(id);
            if (result == null)
            {
                return BadRequest("Error Occurred");
            }
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult> Create(Timeslot timeslot)
        {
            try
            {
                await _timeslotCommandService.Create(timeslot);
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
                await _timeslotCommandService.Delete(id);
                return Ok();
            }

            catch
            {
                return BadRequest();
            }
        }

        [HttpPut]
        public async Task<ActionResult> Update(Timeslot timeslot, int id)
        {
            try
            {
                await _timeslotCommandService.Update(timeslot, id);
                return Ok();
            }

            catch
            {
                return BadRequest();
            }
        }
    }
}
