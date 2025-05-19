using Domain.Entities;
using Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Courses.Queries.GetCoursesByUserId
{
    public class GetCourseByUserIdQueryHandler : IRequestHandler<GetCourseByUserIdQuery, Course?>
    {
        private readonly ICourseRepository _courseRepository;

        public GetCourseByUserIdQueryHandler(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public async Task<Course?> Handle(GetCourseByUserIdQuery request, CancellationToken cancellationToken)
        {
            return await _courseRepository.GetCourseByTeacherIdAsync(request.TeacherId);
        }
    }
}
