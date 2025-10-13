using Domain.Entities;
using Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Courses.Queries.GetAllCoursesByUserId
{
    public class GetAllCoursesByUserIdQueryHandler : IRequestHandler<GetAllCoursesByUserIdQuery, IEnumerable<Course>>
    {
        private readonly ICourseRepository _courseRepository;

        public GetAllCoursesByUserIdQueryHandler(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public async Task<IEnumerable<Course>> Handle(GetAllCoursesByUserIdQuery request, CancellationToken cancellationToken)
        {
            var courses = await _courseRepository.GetCoursesByTeacherIdAsync(request.TeacherId);
            return courses ?? new List<Course>();
        }
    }
}
