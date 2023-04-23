using CalendarBooking.ApplicationLayer.Commands;
using CalendarBooking.ApplicationLayer.DTO;
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
        public async Task<ActionResult<List<GroupDTO>>> GetAllGroups()
        {
            var result = await _groupQueryService.GetAllAsync();
            if (result == null)
            {
                return NotFound("Error Occurred");
            }
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Group>> GetById(int id)
        {
            var result = await _groupQueryService.GetByIdAsync(id);
            if (result == null)
            {
                return NotFound("Error Occurred");
            }
            return Ok(result);
        }

        [HttpPost("{name}")]
        public async Task<ActionResult> Create(string name)
        {
            try
            {
                await _groupCommandService.Create(name);
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
                await _groupCommandService.Delete(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<ActionResult> Update(string name, int id)
        {
            try
            {
                await _groupCommandService.Update(name, id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
