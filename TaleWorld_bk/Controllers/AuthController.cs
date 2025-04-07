using Application;
using Application.Auth.Commands.Login;
using Application.Auth.Commands.Register;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace TaleWorld_bk.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ApiControllerBase
    {
        private readonly IMediator _mediator;
        
        public AuthController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterCommand command)
        {
            var result = await _mediator.Send(command);

            if (!result)
            {
                return BadRequest("Користувач вже існує або дані некоректні.");
            }

            return Ok("Користувач успішно зареєстрований.");
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginCommand command)
        {
            var token = await _mediator.Send(command);
            HttpContext.Response.Cookies.Append("tasty-cookies", token);
            return Ok(token);
        }
    }
}
