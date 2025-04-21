using Domain.Entities.Enum;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Tasks.Commands.Create.Questions
{
    public class CreateTaskQuestionCommand : IRequest<bool>
    {
        public int TypeTaskId { get; set; }
        public int SubTypeId { get; set; }
        public string Question { get; set; }
    }
}
