using Application.Auth.Queries.GetUserByCourseId;
using Application.Auth.Queries.GetUserByFullName;
using Application.Auth.Queries.Users;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace TaleWorld_bk.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ApiControllerBase
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("by-email")]
        public async Task<IActionResult> GetByEmail([FromQuery] string email)
        {
            var query = new GetUserByEmailQuery(email);
            var user = await _mediator.Send(query);

            if (user == null)
                return NotFound();

            return Ok(user);
        }

        [HttpGet("by-fullname")]
        public async Task<IActionResult> GetByFullName([FromQuery] string name, [FromQuery] string surname)
        {
            var query = new GetUserByFullNameQuery(name, surname);
            var user = await _mediator.Send(query);

            if (user == null)
                return NotFound();

            return Ok(user);
        }

        [HttpGet("by-courseId")]
        public async Task<IActionResult> GetUserByCourseId([FromQuery] int courseId)
        {
            var query = new GetUserByCourseIdQuery(courseId);
            var user = await _mediator.Send(query);

            return Ok(user);
        }

    }
}
