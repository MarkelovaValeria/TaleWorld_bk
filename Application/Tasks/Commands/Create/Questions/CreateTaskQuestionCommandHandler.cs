using Application.Auth.Commands.Register;
using Domain.Entities;
using Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Tasks.Commands.Create.Questions
{
    public class CreateTaskQuestionCommandHandler : IRequestHandler<CreateTaskQuestionCommand, bool>
    {
        private readonly ITasksRepository _tasks;

        public CreateTaskQuestionCommandHandler(ITasksRepository tasks)
        {
            _tasks = tasks;
        }

        public async Task<bool> Handle(CreateTaskQuestionCommand request, CancellationToken cancellationToken)
        {
            var question = new TasksQuestions
            {
                SubTypeId = request.SubTypeId,
                TypeId = request.TypeTaskId,
                Question = request.Question
            };
            await _tasks.AddTaskQuestion(question);
            return true;
        }
    }
}
