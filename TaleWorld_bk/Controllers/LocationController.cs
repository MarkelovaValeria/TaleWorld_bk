using Application.Lesson.Commands.Create;
using Application.Lesson.Queries.GetAllLessons;
using Application.Locations.Commands.Create;
using Application.Locations.Queries.GetAllLocationsByMapId;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace TaleWorld_bk.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ApiControllerBase
    {
        private readonly IMediator _mediator;

        public LocationController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("createLesson")]
        public async Task<IActionResult> CreateLesson([FromBody] CreateLocationCommand command)
        {
            var result = await _mediator.Send(command);

            return Ok(new { message = $"Локацію створено!" });
        }

        [HttpGet("byMapGetAllLocation")]
        public async Task<IActionResult> GetLocationsMapId([FromQuery] int mapId)
        {
            var query = new GetAllLocationsByMapIdQuery(mapId);
            var locations = await _mediator.Send(query);

            if (locations == null || !locations.Any())
                return Ok(new { message = "У цього викладача ще немає курсів.", locations = new List<object>() });

            return Ok(locations);
        }
    }
}
