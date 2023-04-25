using CalendarBooking.ApplicationLayer.Commands;
using CalendarBooking.ApplicationLayer.DTO;
using CalendarBooking.ApplicationLayer.Queries;
using CalendarBooking.DomainLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

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
        public async Task<ActionResult<List<BookingDTO>>> GetAllBookings()
        {
            var result = await _bookingQueryService.GetAllAsync();
            if (result == null)
            {
                return NotFound("Error Occurred");
            }
            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Booking>> GetById(int id)
        {
            var result = await _bookingQueryService.GetByIdAsync(id);
            if (result == null)
            {
                return NotFound("Error Occurred");
            }
            return Ok(result);
        }
        [HttpPost]
        public async Task<ActionResult> Create(CreateBookingDTO createBookingDTO)
        {
            try
            {
                await _bookingCommandService.Create(createBookingDTO);
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
                await _bookingCommandService.Delete(id);
                return Ok();
            }

            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<ActionResult> Update(DateTime dateTime, int id)
        {
            try
            {
                await _bookingCommandService.UpdateTimeStart(dateTime, id);
                return Ok();
            }

            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
