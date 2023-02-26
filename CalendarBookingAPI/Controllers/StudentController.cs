

using CalendarBooking.ApplicationLayer.Commands;
using CalendarBooking.ApplicationLayer.Queries;
using CalendarBooking.DomainLayer.Entities;
using Microsoft.AspNetCore.Mvc;


namespace CalendarBooking.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentQueryService _studentQueryService;
        private readonly IStudentCommandService _studentCommandService;
        public StudentController(IStudentQueryService studentQueryService, IStudentCommandService studentCommandService)
        {
            _studentQueryService = studentQueryService;
            _studentCommandService = studentCommandService;
        }
        [HttpGet]
        public async Task<ActionResult<List<Student>>> GetAllStudents()
        {
            var result = await _studentQueryService.GetAll();
            if (result == null)
            {
                return BadRequest("Error Occurred");
            }
            return Ok(result);
        }

     

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Student>>> DeleteStudent(int id)
        {
            var result = await _studentCommandService.Delete(id);
            if (result == null)
            {
                return BadRequest("Error Occurred");
            }
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Student>> FindById(int id)
        {
            var result = await _studentQueryService.FindById(id);
            if (result == null)
            {
                return BadRequest("Error Occurred");
            }
            return Ok(result);
        }

<<<<<<< HEAD
        [HttpPut("{id}")]
        public async Task<ActionResult<Student>> UpdateName(int id, string name)
=======
        [HttpPost]

        public ActionResult Insert(Student entity)
        {            
            _studentCommandService.Insert(entity);
            return Ok(entity);
        }


        [HttpPut("{id}")]
        public async Task<ActionResult<Student?>> Update(Student entity, int id)
>>>>>>> ASAS
        {
            var result = await _studentQueryService.FindById(id);
            if (result is null)
            {
                return NotFound("Error Occurred");
            }
            result.FirstName = entity.FirstName;
            result.LastName = entity.LastName;
           
            return Ok(result);
        }


<<<<<<< HEAD
        [HttpPost]

        public async Task<ActionResult<Student>> AddStudent(string firstName, string lastName)
        {
            var result = await _studentQueryService.AddStudent(firstName, lastName);
            if (result == null)
            {
                return NotFound("Error Occurred");
            }
            return Ok(result);
        }


      
            
=======
>>>>>>> ASAS


    }


}
