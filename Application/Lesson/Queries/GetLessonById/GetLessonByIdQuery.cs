using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Lesson.Queries.GetCoursesById
{
    public class GetLessonByIdQuery : IRequest<Lessons?>
    {
        public int Id { get; set; }

        public GetLessonByIdQuery(int id)
        {
            Id = id;
        }
    }
}
