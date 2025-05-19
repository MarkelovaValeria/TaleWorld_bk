using Domain.Entities;
using Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Courses.Queries.QetAllCourses
{
    public class GetAllCoursesQueryHandler : IRequestHandler<GetAllCoursesQuery, List<Course>>
    {
        private readonly ICourseRepository _courseRepository;

        public GetAllCoursesQueryHandler(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public async Task<List<Course>> Handle(GetAllCoursesQuery request, CancellationToken cancellationToken)
        {
            return await _courseRepository.GetAllCoursesAsync();
        }
    }
}
