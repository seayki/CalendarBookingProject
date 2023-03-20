using Microsoft.AspNetCore.Mvc;

namespace CalendarBooking.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimeslotController : ControllerBase
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
