using Application.Auth.Commands.Register;
using Application.Courses.Queries.GetCoursesById;
using Application.Courses.Queries.QetAllCourses;
using Application.Maps.Commands;
using Application.Maps.Queries.GetAllMaps;
using Application.Maps.Queries.GetMapById;
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

        [HttpGet("all-maps")]
        public async Task<IActionResult> GetAllMaps()
        {
            var query = new GetAllMapsQuery();
            var maps = await _mediator.Send(query);

            return Ok(maps);
        }
        [HttpGet("byId")]
        public async Task<IActionResult> GetMapById([FromQuery] int id)
        {
            var query = new GetMapByIdQuery(id);
            var map = await _mediator.Send(query);

            return Ok(map);
        }
    }
}
