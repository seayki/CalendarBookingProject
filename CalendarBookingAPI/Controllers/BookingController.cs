using CalendarBooking.ApplicationLayer.Commands;
using CalendarBooking.ApplicationLayer.Queries;
using CalendarBooking.DomainLayer.Entities;
using CalendarBooking.InfrastructureLayer.Queries;
using Microsoft.AspNetCore.Http;
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


        //[HttpGet]
        //public async Task<ActionResult<List<Booking>>> GetAllBookings()
        //{
          
        //}

    }
}
