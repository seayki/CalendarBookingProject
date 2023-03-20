using Microsoft.AspNetCore.Mvc;

namespace CalendarBooking.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupController : ControllerBase
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
