using Application.Courses.Queries.GetAllCoursesByUserId;
using Domain.Entities;
using Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Tasks.Queries.GetAllTasksByTeacherId
{
    public class GetAllTasksByTeacherIdQueryHandler : IRequestHandler<GetAllTasksByTeacherIdQuery, IEnumerable<TasksQuestions>>
    {
        private readonly ITasksRepository _tasksRepository;

        public GetAllTasksByTeacherIdQueryHandler(ITasksRepository tasksRepository)
        {
            _tasksRepository = tasksRepository;
        }

        public async Task<IEnumerable<TasksQuestions>> Handle(GetAllTasksByTeacherIdQuery request, CancellationToken cancellationToken)
        {
            var taskquestions = await _tasksRepository.GetTasksQuestionByTeacherIdAsync(request.TeacherId);
            return taskquestions ?? new List<TasksQuestions>();
        }
    }
}
