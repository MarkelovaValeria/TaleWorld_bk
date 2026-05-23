using Domain.Entities;
using Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Lesson.Queries.GetCoursesById
{
    public class GetLessonByIdQueryHandler : IRequestHandler<GetLessonByIdQuery, Lessons?>
    {
        private readonly ILessonRepository _lessonRepository;

        public GetLessonByIdQueryHandler(ILessonRepository lessonRepository)
        {
            _lessonRepository = lessonRepository;
        }

        public async Task<Lessons?> Handle(GetLessonByIdQuery request, CancellationToken cancellationToken)
        {
            return await _lessonRepository.GetLessonByIdAsync(request.Id);
        }
    }
}
