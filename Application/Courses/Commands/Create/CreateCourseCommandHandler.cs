using Domain.Entities;
using Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Courses.Commands.Create
{
    public class CreateCourseCommandHandler : IRequestHandler<CreateCourseCommand, bool>
    {
        private readonly ICourseRepository _course;

        public CreateCourseCommandHandler(ICourseRepository course)
        {
            _course = course;
        }

        public async Task<bool> Handle(CreateCourseCommand request, CancellationToken cancellationToken)
        {
            var courses = new Domain.Entities.Course
            {
                Title = request.Title,
                TeacherId = request.TeacherId,
                CoursePhoto = request.Photo,
                Description =  request.Description,
            };
            await _course.AddCourse(courses);
            return true;
        }
    }
}
