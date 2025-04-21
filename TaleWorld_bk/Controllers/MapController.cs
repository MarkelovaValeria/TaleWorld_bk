using Application.Auth.Commands.Register;
using Application.Maps.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace TaleWorld_bk.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MapController : ApiControllerBase
    {
        private readonly IMediator _mediator;

        public MapController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("createMap")]
        public async Task<IActionResult> CreateMap([FromBody] CreateMapCommand command)
        {
            var result = await _mediator.Send(command);

            return Ok(new { message = $"Карту успішно створено!" });
        }
    }
}
