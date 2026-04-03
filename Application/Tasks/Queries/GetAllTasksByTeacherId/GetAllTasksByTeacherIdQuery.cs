using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Tasks.Queries.GetAllTasksByTeacherId
{
    public class GetAllTasksByTeacherIdQuery : IRequest<IEnumerable<TasksQuestions>>
    {
        public int TeacherId { get;}
        public GetAllTasksByTeacherIdQuery(int teacherId)
        {
            TeacherId = teacherId;
        }
    }
}
