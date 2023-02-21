using Microsoft.AspNetCore.Mvc;
using CalendarBooking.DomainLayer.Entities;
using Microsoft.AspNetCore.Http.HttpResults;
using CalendarBooking.ApplicationLayer.Queries;

namespace CalendarBooking.API.Controllers
{


    namespace CalendarBooking.API.Controllers
    {

        [Route("api/[controller]")]
        [ApiController]
        public class CalendarController : ControllerBase 
        {


            private readonly ICalendarQueryService _calendarQueryService;
            public CalendarController(ICalendarQueryService calendarQueryService)
            {
                _calendarQueryService = calendarQueryService;
            }


            [HttpGet]
            public async Task<ActionResult<List<Calendar>>> GetAll()
            {
                var result = await _calendarQueryService.GetAll();
                if (result == null)
                {
                    return BadRequest("Error Occurred");
                }
                return Ok(result);
            }







        }

    }
}
