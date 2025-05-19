using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Courses.Queries.GetCoursesByUserId
{
    public class GetCourseByUserIdQuery : IRequest<Course?>
    {
        public int TeacherId { get; set; }

        public GetCourseByUserIdQuery(int teacherId)
        {
            TeacherId = teacherId;
        }
    }
}
