using CalendarBooking.ApplicationLayer.Commands;
using CalendarBooking.ApplicationLayer.Queries;
using CalendarBooking.DomainLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CalendarBooking.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {


        private readonly IBookingCommandService _bookingCommandService;
        private readonly IBookingQueryService _bookingQueryService;


        public BookingController(IBookingQueryService bookingQueryService, IBookingCommandService bookingCommandService)
        {
            _bookingQueryService = bookingQueryService;
            _bookingCommandService = bookingCommandService;
        }


        [HttpGet]
        public async Task<ActionResult<List<Booking>>> GetAllBookings()
        {
            var result = await _bookingQueryService.GetAllAsync();
            if (result == null)
            {
                return BadRequest("Error Occurred");
            }
            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Booking>> GetById(int id)
        {
            var result = await _bookingQueryService.GetByIdAsync(id);
            if (result == null)
            {
                return BadRequest("Error Occurred");
            }
            return Ok(result);
        }
        [HttpPost]
        public async Task<ActionResult> Create(Booking booking)
        {
            try
            {
                await _bookingCommandService.Create(booking);
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
                await _bookingCommandService.Delete(id);
                return Ok();
            }

            catch
            {
                return BadRequest();
            }
        }

        [HttpPut]
        public async Task<ActionResult> Update(Booking booking, int id)
        {
            try
            {
                await _bookingCommandService.Update(booking, id);
                return Ok();
            }

            catch
            {
                return BadRequest();
            }
        }
    }
}
