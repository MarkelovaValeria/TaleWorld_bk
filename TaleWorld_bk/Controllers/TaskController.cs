using Application.Auth.Commands.Register;
using Application.Courses.Queries.GetAllCoursesByUserId;
using Application.Tasks.Commands.Create.Options;
using Application.Tasks.Commands.Create.Questions;
using Application.Tasks.Queries.GetAllTaskOptionsByQuetionId;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace TaleWorld_bk.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ApiControllerBase
    {
        private readonly IMediator _mediator;

        public TaskController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("createQuestion")]
        public async Task<IActionResult> CreateQuestion([FromBody] CreateTaskQuestionCommand command)
        {
            var result = await _mediator.Send(command);

            return Ok(new { message = $"Питання створено!" });
        }
        [HttpPost("createOption")]
        public async Task<IActionResult> CreateOption([FromBody] CreateTaskOptionsCommand command)
        {
            var result = await _mediator.Send(command);

            return Ok(new { message = $"Варіант створено!" });
        }

        [HttpGet("byUserGetAllTaskQuestions")]
        public async Task<IActionResult> GetTaskQuestionsByUserId([FromQuery] int teacherId)
        {
            var query = new GetAllCoursesByUserIdQuery(teacherId);
            var questions = await _mediator.Send(query);

            if (questions == null || !questions.Any())
                return Ok(new { message = "У цього викладача ще немає створених завдань.", questions = new List<object>() });

            return Ok(questions);
        }

        [HttpGet("byQuestionGetAllTaskOptions")]
        public async Task<IActionResult> GetTaskOptionsByQuestion([FromQuery] int questionId)
        {
            var query = new GetAllTaskOptionsByQuetionIdQuery(questionId);
            var options = await _mediator.Send(query);

            if (options == null || !options.Any())
                return Ok(new { message = "У цього викладача ще немає створених завдань.", options = new List<object>() });

            return Ok(options);
        }
    }
}
