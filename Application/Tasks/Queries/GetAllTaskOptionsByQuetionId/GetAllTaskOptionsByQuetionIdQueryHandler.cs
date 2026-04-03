using Application.Tasks.Queries.GetAllTasksByTeacherId;
using Domain.Entities;
using Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Tasks.Queries.GetAllTaskOptionsByQuetionId
{
    public class GetAllTaskOptionsByQuetionIdQueryHandler : IRequestHandler<GetAllTaskOptionsByQuetionIdQuery, IEnumerable<TaskOptions>>
    {
        private readonly ITasksRepository _tasksRepository;

        public GetAllTaskOptionsByQuetionIdQueryHandler(ITasksRepository tasksRepository)
        {
            _tasksRepository = tasksRepository;
        }

        public async Task<IEnumerable<TaskOptions>> Handle(GetAllTaskOptionsByQuetionIdQuery request, CancellationToken cancellationToken)
        {
            var taskquestions = await _tasksRepository.GetAllTasksOptionsByQuestionsIdAsync(request.QuestionId);
            return taskquestions ?? new List<TaskOptions>();
        }
    }
}
