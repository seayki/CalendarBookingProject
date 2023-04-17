using CalendarBooking.ApplicationLayer.Commands;
using CalendarBooking.ApplicationLayer.Queries;
using CalendarBooking.DomainLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CalendarBooking.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupController : ControllerBase
    {


        private readonly IGroupQueryService _groupQueryService;
        private readonly IGroupCommandService _groupCommandService;

        public GroupController(IGroupQueryService groupQueryService, IGroupCommandService groupCommandService)
        {

            _groupQueryService = groupQueryService;
            _groupCommandService = groupCommandService;
        }


        [HttpGet]
        public async Task<ActionResult<List<Group>>> GetAllGroups()
        {
            var result = await _groupQueryService.GetAllAsync();
            if (result == null)
            {
                return BadRequest("Error Occurred");
            }
            return Ok(result);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Group>> GetById(int id)
        {
            var result = await _groupQueryService.GetByIdAsync(id);
            if (result == null)
            {
                return BadRequest("Error Occurred");
            }
            return Ok(result);
        }


        [HttpPost]
        public async Task<ActionResult> Create(Group group)
        {
            try
            {
                await _groupCommandService.Create(group);
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
                await _groupCommandService.Delete(id);
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPut]
        public async Task<ActionResult> Update(Group group, int id)
        {
            try
            {
                await _groupCommandService.Update(group, id);
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
