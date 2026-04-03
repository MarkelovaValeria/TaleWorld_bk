using Domain.Entities;
using Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Courses.Queries.GetCoursesById
{
    public class GetCourseByIdQueryHandler : IRequestHandler<GetCourseByIdQuery, Course?>
    {
        private readonly ICourseRepository _courseRepository;

        public GetCourseByIdQueryHandler(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public async Task<Course?> Handle(GetCourseByIdQuery request, CancellationToken cancellationToken)
        {
            return await _courseRepository.GetCourseByIdAsync(request.Id);
        }
    }
}
