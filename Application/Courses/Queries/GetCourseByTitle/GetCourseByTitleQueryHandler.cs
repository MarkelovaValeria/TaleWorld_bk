using Domain.Entities;
using Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Courses.Queries.GetCourseByName
{
    public class GetCourseByTitleQueryHandler : IRequestHandler<GetCourseByTitleQuery, Course?>
    {
        private readonly ICourseRepository _courseRepository;

        public GetCourseByTitleQueryHandler(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public async Task<Course?> Handle(GetCourseByTitleQuery request, CancellationToken cancellationToken)
        {
            return await _courseRepository.GetCourseByTitleAsync(request.Title);
        }
    }
}
