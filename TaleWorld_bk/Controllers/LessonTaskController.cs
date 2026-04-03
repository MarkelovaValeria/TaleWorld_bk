using Application.Lesson.Commands.Create;
using Application.LessonsTasks.Commands.Create;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace TaleWorld_bk.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LessonTaskController : ApiControllerBase
    {
        private readonly IMediator _mediator;

        public LessonTaskController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("addTaskToLesson")]
        public async Task<IActionResult> AddTaskToLesson([FromBody] CreateLessonTaskCommand command)
        {
            var result = await _mediator.Send(command);

            return Ok(new { message = $"Завдання додано до уроку!" });
        }


    }
}
