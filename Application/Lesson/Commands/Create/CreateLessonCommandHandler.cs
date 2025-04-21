using Domain.Entities;
using Domain.Entities.Admin.Map;
using Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Lesson.Commands.Create
{
    public class CreateLessonCommandHandler : IRequestHandler<CreateLessonCommand, bool>
    {
        private readonly ILessonRepository _lesson;

        public CreateLessonCommandHandler(ILessonRepository lesson)
        {
            _lesson = lesson;
        }

        public async Task<bool> Handle(CreateLessonCommand request, CancellationToken cancellationToken)
        {
            var lessons = new Lessons 
            {
                Title = request.Title,
                MapId = request.MapId,
                CourseId = request.CourseId,
            };
            await _lesson.AddLesson(lessons);
            return true;
        }
    }
}
