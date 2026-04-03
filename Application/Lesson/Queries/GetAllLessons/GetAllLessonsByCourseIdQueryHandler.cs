using Application.Courses.Queries.GetAllCoursesByUserId;
using Application.Maps.Queries.GetAllMaps;
using Domain.Entities;
using Domain.Entities.Admin.Map;
using Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Lesson.Queries.GetAllLessons
{
    public class GetAllLessonsByCourseIdQueryHandler : IRequestHandler<GetAllLessonsByCourseIdQuery, IEnumerable<Lessons>>
    {
        private readonly ILessonRepository _lessonRepository;

        public GetAllLessonsByCourseIdQueryHandler(ILessonRepository lessonRepository)
        {
            _lessonRepository = lessonRepository;
        }

        public async Task<IEnumerable<Lessons>> Handle(GetAllLessonsByCourseIdQuery request, CancellationToken cancellationToken)
        {
            var lessons = await _lessonRepository.GetAllLessonsByCourseIdAsync(request.CourseId);
            return lessons ?? new List<Lessons>();
        }
    }
}
