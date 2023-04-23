using CalendarBooking.ApplicationLayer.Commands;
using CalendarBooking.ApplicationLayer.DTO;
using CalendarBooking.ApplicationLayer.Queries;
using CalendarBooking.DomainLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace CalendarBooking.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : Controller
    {

        private readonly IUserQueryService _userQueryService;
        private readonly IUserCommandService _userCommandService;
        private readonly IConfiguration _configuration;

        public AuthController(IUserQueryService userQueryService, IUserCommandService userCommandService, IConfiguration configuration)
        {
            _userQueryService = userQueryService;
            _userCommandService = userCommandService;
            _configuration = configuration;
        }


        [HttpPost("Register")]
        public async Task<ActionResult> Register(UserDTO request)
        {
            try
            {
                await _userCommandService.Create(request);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpPost("Login")]
        public async Task<ActionResult<User>> Login(UserDTO request)
        {
            var result = await _userQueryService.GetByUsername(request.Username);
            if (result == null)
            {
                return BadRequest("Wrong username or password.");
            }

            if(!BCrypt.Net.BCrypt.Verify(request.Password, result.PasswordHash))
            {
                return BadRequest("Wrong username or password.");
            }

            string token = CreateToken(result);
            return Ok(token);
        }

        private string CreateToken(User user)
        {
            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.UserName)
            };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration.GetSection("AppSettings:Token").Value!));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);
            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: creds 
                );
            var jwt = new JwtSecurityTokenHandler().WriteToken(token);
            return jwt;
        }
    }
}
               


