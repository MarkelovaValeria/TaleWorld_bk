using Application.Lesson.Commands.Create;
using Domain.Interfaces;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.LessonsTasks.Commands.Create
{
    public class CreateLessonTaskCommandHandler : IRequestHandler<CreateLessonTaskCommand, bool>
    {
        private readonly ILessonTaskRepository _lt;

        public CreateLessonTaskCommandHandler(ILessonTaskRepository lt)
        {
            _lt = lt;
        }


        public async Task<bool> Handle(CreateLessonTaskCommand request, CancellationToken cancellationToken)
        {
            var lt = new LessonTask
            {
                LessonId = request.LessonId,
                TaskQuestionId = request.TaskId,
            };
            await _lt.AddTaskToLesson(lt);
            return true;
        }
    }
}
