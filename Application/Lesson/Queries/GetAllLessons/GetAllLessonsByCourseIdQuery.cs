using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Lesson.Queries.GetAllLessons
{
    public class GetAllLessonsByCourseIdQuery : IRequest<IEnumerable<Lessons>>
    {
        public int CourseId { get; }
        public GetAllLessonsByCourseIdQuery(int courseId)
        {
            CourseId = courseId;
        }
    }
}
