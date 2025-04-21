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
    public class LessonRepository : ILessonRepository
    {
        private readonly TWDbContext _context;

        public LessonRepository(TWDbContext context)
        {
            _context = context;
        }

        public async Task AddLesson(Lessons lessons)
        {
            await _context.Lessons.AddAsync(lessons);
            await _context.SaveChangesAsync();
        }
    }
}
