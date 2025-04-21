using Application.Tasks.Commands.Create.Questions;
using Domain.Entities;
using Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Tasks.Commands.Create.Options
{
    public class CreateTaskOptionsCommandHandler : IRequestHandler<CreateTaskOptionsCommand, bool>
    {
        private readonly ITasksRepository _tasks;

        public CreateTaskOptionsCommandHandler(ITasksRepository tasks)
        {
            _tasks = tasks;
        }

        public async Task<bool> Handle(CreateTaskOptionsCommand request, CancellationToken cancellationToken)
        {
            var options = new TaskOptions
            {
                TaskQuestionsId = request.TaskQuestionId,
                OptionText = request.OptionText,
                IsCorrect = request.IsCorrect,
            };
            await _tasks.AddTaskOptions(options);
            return true;
        }
    }
}
