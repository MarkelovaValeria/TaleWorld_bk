using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.LessonsTasks.Commands.Create
{
    public class CreateLessonTaskCommand : IRequest<bool>
    {
        public int LessonId { get; set; }
        public int TaskId { get; set; }
    }
}
