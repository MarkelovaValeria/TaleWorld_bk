using Domain.Entities;
using Domain.Entities.Admin.Map;
using Domain.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
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

        public async Task<Lessons> GetLessonByIdAsync(int lessonId)
        {
            return await _context.Lessons
                .FirstOrDefaultAsync(l => l.Id == lessonId);
        }

        public async Task<IEnumerable<Lessons>> GetAllLessonsByCourseIdAsync(int courseId)
        {
            return await _context.Lessons
                .Where(c => c.CourseId == courseId)
                .ToListAsync();
        }

    }
}
