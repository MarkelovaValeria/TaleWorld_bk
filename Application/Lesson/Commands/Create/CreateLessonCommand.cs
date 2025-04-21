using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Lesson.Commands.Create
{
    public class CreateLessonCommand : IRequest<bool>
    {
        public string Title { get; set; }
        public int CourseId { get; set; }
        public int MapId { get; set; }
    }
}
