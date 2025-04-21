using Application.Auth.Commands.Register;
using Application.Tasks.Commands.Create.Options;
using Application.Tasks.Commands.Create.Questions;
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
    }
}
