using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Course.Commands.Create
{
    public class CreateCourseCommand : IRequest<bool>
    {
        public string Title { get; set; }
        public int TeacherId { get; set; }
    }
}
