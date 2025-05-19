using Application.Lesson.Commands.Create;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace TaleWorld_bk.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LessonController : ApiControllerBase
    {
        private readonly IMediator _mediator;

        public LessonController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("createLesson")]
        public async Task<IActionResult> CreateLesson([FromBody] CreateLessonCommand command)
        {
            var result = await _mediator.Send(command);

            return Ok(new { message = $"Урок створено!" });
        }
    }
}
