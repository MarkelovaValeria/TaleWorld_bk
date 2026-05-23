using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Tasks.Queries.GetAllTaskOptionsByQuetionId
{
    public class GetAllTaskOptionsByQuetionIdQuery : IRequest<IEnumerable<TaskOptions>>
    {
        public int QuestionId { get; }
        public GetAllTaskOptionsByQuetionIdQuery(int questionId)
        {
            QuestionId = questionId;
        }
    }
}
