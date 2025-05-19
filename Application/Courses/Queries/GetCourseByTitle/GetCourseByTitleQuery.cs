using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Courses.Queries.GetCourseByName
{
    public class GetCourseByTitleQuery : IRequest<Course?>
    {
        public string Title { get; set; }

        public GetCourseByTitleQuery(string title)
        {
            Title = title;
        }
    }
}
