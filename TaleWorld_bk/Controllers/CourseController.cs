using Application.Auth.Queries.GetUserByFullName;
using Application.Courses.Commands.Create;
using Application.Courses.Queries.GetCoursesById;
using Application.Courses.Queries.GetCoursesByUserId;
using Application.Courses.Queries.QetAllCourses;
using Application.Tasks.Commands.Create.Options;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace TaleWorld_bk.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ApiControllerBase
    {
        private readonly IMediator _mediator;

        public CourseController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("createCourse")]
        public async Task<IActionResult> CreateCourse([FromBody] CreateCourseCommand command)
        {
            var result = await _mediator.Send(command);

            return Ok(new { message = $"Курс створено!" });
        }

        [HttpGet("all-courses")]
        public async Task<IActionResult> GetAllCourses()
        {
            var query = new GetAllCoursesQuery();
            var course = await _mediator.Send(query);

            return Ok(course);
        }

        [HttpGet("byId")]
        public async Task<IActionResult> GetCourseById([FromQuery] int id)
        {
            var query = new GetCourseByIdQuery(id);
            var course = await _mediator.Send(query);

            if (course == null)
                return NotFound();

            return Ok(course);
        }

    }
}
