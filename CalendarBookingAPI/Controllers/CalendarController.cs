using CalendarBooking.ApplicationLayer.Commands;
using CalendarBooking.ApplicationLayer.Queries;
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
    }
}
