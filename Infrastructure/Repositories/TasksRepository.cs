using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class TasksRepository : ITasksRepository
    {
        private readonly TWDbContext _context;

        public TasksRepository(TWDbContext context)
        {
            _context = context;
        }

        public async Task AddTaskQuestion(TasksQuestions tasksquestion)
        {
            await _context.TasksQuestions.AddAsync(tasksquestion);
            await _context.SaveChangesAsync();
        }

        public async Task AddTaskOptions(TaskOptions taskOptions)
        {
            await _context.TaskOptions.AddAsync(taskOptions);
            await _context.SaveChangesAsync();
        }

        
    }
}
