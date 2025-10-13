using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Courses.Queries.GetAllCoursesByUserId
{
    public class GetAllCoursesByUserIdQuery : IRequest<IEnumerable<Course>>
    {
        public int TeacherId { get; }

        public GetAllCoursesByUserIdQuery(int teacherId)
        {
            TeacherId = teacherId;
        }
    }
}
