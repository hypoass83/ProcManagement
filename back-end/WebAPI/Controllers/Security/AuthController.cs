using Application.DTOs.Auth;
using Application.Services.Secutity;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers.Security
{
    [ApiController]
    [Route("api/auth")]
    public class AuthController : ControllerBase
    {
        private readonly AuthService _authService;

        public AuthController(AuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginRequest request)
        {
            var result = await _authService.Login(request);

            if (!result.Success)
                return Unauthorized(result);

            return Ok(result);
        }
    }
}
