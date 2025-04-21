using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface ITasksRepository
    {
        Task AddTaskQuestion(TasksQuestions tasksLocation);
        Task AddTaskOptions(TaskOptions taskOptions);
    }
}
