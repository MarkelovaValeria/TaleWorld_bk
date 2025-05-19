using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Courses.Queries.GetCoursesById
{
    public class GetCourseByIdQuery : IRequest<Course?>
    {
        public int Id { get; set; }

        public GetCourseByIdQuery(int id)
        {
            Id = id;
        }
    }
}
