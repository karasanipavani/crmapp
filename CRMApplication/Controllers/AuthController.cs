using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CRMApplication.Models;
using CRMApplication.Services;
using System.Threading.Tasks;

namespace CRMApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest loginRequest)
        {
            var token = await _authService.Authenticate(loginRequest);
            if (token == null)
            {
                return Unauthorized();
            }
            return Ok(new { Token = token });
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequest registerRequest)
        {
            await _authService.Register(registerRequest);
            return Ok();
        }
    }
}
