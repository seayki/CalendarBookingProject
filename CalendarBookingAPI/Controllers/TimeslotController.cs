using CalendarBooking.ApplicationLayer.Commands;
using CalendarBooking.ApplicationLayer.DTO;
using CalendarBooking.ApplicationLayer.Queries;
using CalendarBooking.DomainLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
        public async Task<ActionResult<List<TimeslotDTO>>> GetAll()
        {
            var result = await _timeslotQueryService.GetAllAsync();
            if (result == null)
            {
                return NotFound("Error Occurred");
            }
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Timeslot>> GetById(int id)
        {
            var result = await _timeslotQueryService.GetByIdAsync(id);
            if (result == null)
            {
                return NotFound("Error Occurred");
            }
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult> Create(CreateTimeslotDTO createTimeslotDTO)
        {
            try
            {
                await _timeslotCommandService.Create(createTimeslotDTO);
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
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

            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }  
    }
}
