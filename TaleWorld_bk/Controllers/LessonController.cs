using Application.Courses.Queries.GetAllCoursesByUserId;
using Application.Courses.Queries.GetCoursesById;
using Application.Lesson.Commands.Create;
using Application.Lesson.Queries.GetAllLessons;
using Application.Lesson.Queries.GetCoursesById;
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

        [HttpGet("byId")]
        public async Task<IActionResult> GetLessonById([FromQuery] int id)
        {
            var query = new GetLessonByIdQuery(id);
            var lesson = await _mediator.Send(query);

            if (lesson == null)
                return NotFound();

            return Ok(lesson);
        }

        [HttpGet("byCourseGetAllLessons")]
        public async Task<IActionResult> GetLessonsByCourseId([FromQuery] int courseId)
        {
            var query = new GetAllLessonsByCourseIdQuery(courseId);
            var lessons = await _mediator.Send(query);

            if (lessons == null || !lessons.Any())
                return Ok(new { message = "У цього викладача ще немає курсів.", lessons = new List<object>() });

            return Ok(lessons);
        }
    }
}
