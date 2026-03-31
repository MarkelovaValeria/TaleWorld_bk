using Domain.Entities;
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
        private readonly ILocationRepository _locationTemplate;

        public CreateLessonCommandHandler(
            ILessonRepository lesson,
            ILocationRepository locationTemplate)
        {
            _lesson = lesson;
            _locationTemplate = locationTemplate;
        }

        public async Task<bool> Handle(CreateLessonCommand request, CancellationToken cancellationToken)
        {
            var location = await _locationTemplate.GetById(request.LocationId);

            if (location == null)
            {
                throw new Exception("LocationTemplate не знайдено");
            }

            var lesson = new Lessons
            {
                Title = request.Title ?? location.Text,
                Description = location.Text,
                CourseId = request.CourseId,
                TemplateId = location.Id
            };

            await _lesson.AddLesson(lesson);
            return true;
        }
    }
}
