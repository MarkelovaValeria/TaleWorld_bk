using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Auth.Queries.GetUserByCourseId
{
    public class GetUserByCourseIdQuery : IRequest<User>
    {
        public int CourseId { get; set; }

        public GetUserByCourseIdQuery(int courseId)
        {
            CourseId = courseId;
        }
    }
}
