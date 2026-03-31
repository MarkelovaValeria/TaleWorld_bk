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
    public class LessonTaskRepository : ILessonTaskRepository
    {
        private readonly TWDbContext _context;

        public LessonTaskRepository(TWDbContext context)
        {
            _context = context;
        }

        public async Task AddTaskToLesson(LessonTask lt)
        {
            await _context.LessonTasks.AddAsync(lt);
            await _context.SaveChangesAsync();
        }
    }
}
