using Microsoft.AspNetCore.Mvc;

namespace CalendarBooking.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
